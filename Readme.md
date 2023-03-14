## SVS2TIFF

<p align="center">
  <img width="256" height="256" src="svs2tiff.png">
</p>

### Table of contents

+ [About](#about)
+ [Prerequisites](#requirements)
+ [Installing](#install)
+ [Usage](#usage)
+ [Contributing](#contributing)

### About <a name = "about"></a>

This repository contains a visual studio solution with the following projects.

1. SVS2TIFF
This project contains the application and required binaries

2. SVS2TIFF-Setup
This project contains Wix setup project to make msi installer for windows.

### Prerequisites <a name = "requirements"></a>

#### Building with Visual Studio 2019 Community Edition
* SVS2TIFF project requires .NET framework 4.7, NetVips 2.2.0 and libvips binaries.
* Binaries for libvips ([vips-dev-w64-all-8.13.0.zip](https://github.com/libvips/build-win64-mxe/releases/download/v8.13.0/vips-dev-w64-all-8.13.0.zip)) are included in the libvips directory of the SVS2TIFF project. Add libvips binaries to Path or to the same directory as the SVS2TIFF executable
* SVS2TIFF-Setup requires Wix Toolset V3.x installed on the system. Add Wix Toolset to Path. 
* Build the SVS2TIFF-Setup project to make msi installer. 

### Installing <a name = "install"></a>

Please download the most current version of SVS2TIFF from the releases tab in GitHub.  The msi installer will install SVS2TIFF with the included libvips binaries.

### Usage <a name = "usage"></a>

<p align="center">
  <img width="400" src=https://user-images.githubusercontent.com/10900214/225036447-1f706b09-0114-441f-ab1b-f75ec7554a45.PNG>
</p>

* Use SVS2TIFF to convert Aperio SVS files to TIFF or OME-TIFF (.ome.tif).
* Select the type of compression for the converted files (i.e. lzw, jpeg, jp2k) or leave it "none" for uncompressed data.
* Check "Write OME-TIFF" check box to write files that readable by BioFormats and hence are compatible with QuPath with additional steps.
* Writing OME-TIFF with compression may require you to set the BigTIFF flag to true (check the BigTIFF check box)

### Contributing <a name = "contributing"></a>

Please contact [Ajay Zalavadia](https://ajay1685.github.io/) at Lerner Research Institute, Cleveland Clinic if you would like to contribute to the SVS2TIFF file converter. 

## Authors

* **Ajay Zalavadia, Ph.D.** - *SVS2TIFF Convert Aperio SVS files to TIFF or OME-TIFF* - [@ajay1685](https://github.com/ajay1685)
* **Authors of [libvips](https://github.com/libvips/libvips), [NetVips](https://github.com/kleisauke/net-vips) and [Openslide](https://github.com/openslide/openslide)** - *Thanks for their support and help*
