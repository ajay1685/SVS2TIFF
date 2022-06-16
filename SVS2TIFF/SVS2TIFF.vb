Imports System.IO
Imports NetVips
Imports NetVips.Enums

Public Class SVS2TIFF
    ' variables
    Public Property CancelFlag As Boolean = True
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        OutPut.AppendText($"libvips version: {NetVips.NetVips.Version(0)}.{NetVips.NetVips.Version(1)}.{NetVips.NetVips.Version(2)}" & vbCrLf)
        Cbx_compression.Items.Add(ForeignTiffCompression.None)
        Cbx_compression.Items.Add(ForeignTiffCompression.Lzw)
        Cbx_compression.Items.Add(ForeignTiffCompression.Jpeg)
        Cbx_compression.Items.Add(ForeignTiffCompression.Jp2k)
        Cbx_compression.SelectedIndex = Cbx_compression.Items.IndexOf(ForeignTiffCompression.None)

    End Sub

    Private Sub Btn_info_Click(sender As Object, e As EventArgs) Handles Btn_info.Click
        If File.Exists(TextBoxFileName.Text) Then
            If CB_ProcessAll.Checked Then
                Dim DirectoryName = Path.GetDirectoryName(TextBoxFileName.Text)
                Dim files As New List(Of String)
                files.AddRange(Directory.GetFiles(DirectoryName, "*.svs"))
                files.AddRange(Directory.GetFiles(DirectoryName, "*.scn"))

                For Each file As String In files
                    PrintFileInfo(file)
                Next
            Else
                PrintFileInfo(TextBoxFileName.Text)
            End If
        Else
            OutPut.AppendText("Please select a valid file..." & vbCrLf)
        End If
    End Sub

    Private Sub Btn_selectfile_Click(sender As Object, e As EventArgs) Handles Btn_selectfile.Click
        ' Choose an Image File 
        OpenFileDialog1.Title = "Please select a SVS or SCN file"
        OpenFileDialog1.InitialDirectory = "%userprofile%\desktop"
        OpenFileDialog1.Filter = "Aperio SVS files (*.svs)|*.svs|Leica SCN files (*.scn)|*.scn|TIFF files (*.tif)|*.tif|All files (*.*)|*.*" 'Leica SCN files (*.scn)|*.scn

        If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
            TextBoxFileName.Text = OpenFileDialog1.FileName
        End If

    End Sub

    Private Sub Btn_convert_Click(sender As Object, e As EventArgs) Handles Btn_convert.Click

        If Not File.Exists(TextBoxFileName.Text) Then
            OutPut.AppendText("Please select a valid file..." & vbCrLf)
            Exit Sub
        End If

        CancelFlag = False
        Dim DirectoryName = Path.GetDirectoryName(TextBoxFileName.Text)
        Dim files As New List(Of String)

        If CB_ProcessAll.Checked Then
            files.AddRange(Directory.GetFiles(DirectoryName, "*.svs"))
            files.AddRange(Directory.GetFiles(DirectoryName, "*.scn"))
        Else
            files.Add(TextBoxFileName.Text)
        End If

        Btn_convert.Enabled = False
        For Each file As String In files
            If Not CancelFlag Then
                SVS2TIFF(file, String.Empty)
            End If
        Next
        Btn_convert.Enabled = True

    End Sub

    Sub PrintFileInfo(ByVal svsPath As String)
        OutPut.AppendText(vbCrLf & "Info: " & svsPath & vbCrLf)

        Dim im As Image
        Try
            im = NetVips.Image.NewFromFile(svsPath)
        Catch ex As Exception
            OutPut.AppendText("File format not supported" & vbCrLf)
            Exit Sub
        End Try
        Dim loader As String = im.Get("vips-loader").ToString()
        Dim fields As String() = im.GetFields()
        OutPut.AppendText("libvips loader: " & loader & vbCrLf)

        Try
            If im.HasAlpha() Then
                im = im.ExtractBand(0, im.Bands - 1)
            End If
            OutPut.AppendText("Height: " & im.Height & ", Width: " & im.Width & ", Bands: " & im.Bands & ", Pixel interpretation: " & im.Interpretation & vbCrLf)
            If loader = "openslideload" Then
                OutPut.AppendText("Micron per pixel X: " & im.Get("openslide.mpp-x").ToString & " Y: " & im.Get("openslide.mpp-y").ToString & vbCrLf)
                OutPut.AppendText("Magnification: " & im.Get("openslide.objective-power").ToString & "X" & vbCrLf)
                If im.Get("openslide.vendor").ToString() = "aperio" Then

                    If fields.Contains("aperio.BestFocusLayer") Then
                        OutPut.AppendText("Aperio z-stack with best focus layer: " & im.Get("aperio.BestFocusLayer").ToString() & " & Total ")
                    End If
                    OutPut.AppendText("level: " & im.Get("openslide.level-count").ToString & vbCrLf)
                End If

                'OutPut.AppendText("Height: " & im.Get("height").ToString & " Width: " & im.Get("width").ToString & " Bands: " & im.Bands & vbCrLf)
            Else
                For Each field In fields
                    OutPut.AppendText(field & ": " & im.Get(field).ToString() & vbCrLf)
                Next
            End If

        Catch ex As Exception
            OutPut.AppendText("Error: " & ex.Message & vbCrLf)
        Finally
            If im Then
                im.Close()
                im.Dispose()
            End If
        End Try
    End Sub

    Sub SVS2TIFF(ByVal svsPath As String, ByVal tiffPath As String)

        OutPut.AppendText(vbCrLf & "Processing: " & svsPath & vbCrLf)
        Debug.WriteLine("Converting SVS to TIFF: " & svsPath)
        Dim stopwatch As New Stopwatch
        stopwatch.Start()

        If tiffPath Is String.Empty Then
            tiffPath = Path.ChangeExtension(svsPath, ".tif")
        End If

        Dim im As Image
        Try
            im = Image.Openslideload(svsPath, autocrop:=True, access:=Access.Sequential)
        Catch ex As Exception
            OutPut.AppendText("File type not supported by openslide" & vbCrLf & ex.Message & vbCrLf)
            Exit Sub
        End Try

        'openslide adds an alpha channel, so remove it
        If im.HasAlpha() Then
            im = im.ExtractBand(0, im.Bands - 1)
        End If

        'read useful info
        Dim Height = im.Height
        Dim Bands = im.Bands
        Dim Width = im.Width
        Dim CalibrationX = im.Get("openslide.mpp-x").ToString()
        Dim CalibrationY = im.Get("openslide.mpp-y").ToString()
        Dim Magnification = im.Get("openslide.objective-power").ToString()

        'print some info
        OutPut.AppendText("height: " & Height & vbCrLf)
        OutPut.AppendText("width: " & Width & vbCrLf)
        OutPut.AppendText("bands: " & Bands & vbCrLf)
        OutPut.AppendText("Micron per pixel X: " & CalibrationX & vbCrLf)
        OutPut.AppendText("Micron per pixel Y: " & CalibrationY & vbCrLf)
        OutPut.AppendText("Magnification: " & Magnification & "X" & vbCrLf)

        'make a copy, set properties, add minimal metadata in OME-XML format 
        im = im.Copy()
        im = im.Mutate(Sub(mutable)
                           mutable.[Set](NetVips.GValue.GIntType, "page-height", Height)
                           mutable.[Set](NetVips.GValue.GStrType, "image-description",
                               $"<?xml version=""1.0"" encoding=""UTF-8""?>
                                <OME xmlns = ""http://www.openmicroscopy.org/Schemas/OME/2016-06""
                                xmlns:xsi=""http//www.w3.org/2001/XMLSchema-instance""
                                    xsi:schemaLocation=""http//www.openmicroscopy.org/Schemas/OME/2016-06 http://www.openmicroscopy.org/Schemas/OME/2016-06/ome.xsd"">
                                    <Instrument ID=""Instrument:0"">
                                            <Objective ID=""Objective:0"" Immersion=""Air"" NominalMagnification=""{Magnification}""/>
                                    </Instrument>
                                    <Image ID=""Image0"">
                                        <!-- Minimum required fields about image dimensions -->
                                        <InstrumentRef ID=""Instrument:0""/>
                                        <ObjectiveSettings ID=""Objective:0""/>
                                        <Pixels DimensionOrder=""XYCZT""
                                                ID=""Pixels:0""
                                                SizeC=""{Bands}""
                                                SizeT=""1""
                                                SizeX=""{Width}""
                                                SizeY=""{Height}""
                                                SizeZ=""1""
                                                Type=""uint8""
                                                PhysicalSizeX=""{CalibrationX}""
                                                PhysicalSizeXUnit=""µm""
                                                PhysicalSizeY=""{CalibrationY}""
                                                PhysicalSizeYUnit=""µm"">
                                        </Pixels>
                                    </Image>
                                </OME>")
                       End Sub)

        'Monitor progress of the operation
        im.SetProgress(True)
        im.SignalConnect(Enums.Signals.Eval, New Image.EvalDelegate(AddressOf EvalHandler))

        Dim saveOption As New VOption
        saveOption.Add("compression", Cbx_compression.SelectedItem)
        If Chk_ometiff.Checked Then
            saveOption.Add("pyramid", True)
            saveOption.Add("tile", True)
            saveOption.Add("subifd", True)
            tiffPath = Path.ChangeExtension(svsPath, ".ome.tif")
        End If
        If Chk_bigtiff.Checked Then
            saveOption.Add("bigtiff", True)
        End If

        Try
            im.WriteToFile(tiffPath, saveOption)
        Catch ex As Exception
            OutPut.AppendText(ex.Message)
        End Try

        im.Close()
        im.Dispose()
        stopwatch.Stop()
        OutPut.AppendText("Conversion time: " & stopwatch.Elapsed.Hours & ":" & stopwatch.Elapsed.Minutes & ":" & stopwatch.Elapsed.Seconds & " (hh:mm:ss)" & vbCrLf)
        pBar_main.Value = 0
    End Sub

    Sub EvalHandler(ByVal image As Image, ByVal progress As VipsProgress)
        'Console.WriteLine($"run time so far (secs) = {progress.Run}")
        'Console.WriteLine($"estimated time of arrival (secs) = {progress.Eta}")
        'Console.WriteLine($"total number of pels to process = {progress.TPels}")
        'Console.WriteLine($"number of pels processed so far = {progress.NPels}")
        'Debug.WriteLine($"percent complete = {progress.Percent}")
        pBar_main.Value = progress.Percent
        Application.DoEvents()
    End Sub

    Private Sub Btn_cancel_Click(sender As Object, e As EventArgs) Handles Btn_cancel.Click
        If Not CancelFlag Then
            OutPut.AppendText("Process will be terminated after completing this file" & vbCrLf)
        End If
        CancelFlag = True
    End Sub

    Private Sub Btn_clear_Click(sender As Object, e As EventArgs) Handles Btn_clear.Click
        OutPut.Clear()
    End Sub

End Class
