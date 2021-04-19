# How-to-resolve-the-default-image-rotation-issue-when-loading-the-image-to-the-Image-Editor-
This article explains how to resolve the default image rotation issue when loading the image to the Syncfusion Image Editor on Xamarin.Forms Android platform. 

The reason for this issue, the specific image containing the EXIF metadata orientation like 90, 270 etc., and taking the image from mobile camera in landscape mode. 

Before resolving the image rotation at load time.

![BeforeResolvingImageRotation](https://github.com/SyncfusionExamples/How-to-resolve-the-default-image-rotation-issue-when-loading-the-image-to-the-Image-Editor-/tree/main/OutputImages/BeforeResolvingImageRotation.jpg)

After resolving the image rotation at load time.

![AfterResolvingImageRotation](https://github.com/SyncfusionExamples/How-to-resolve-the-default-image-rotation-issue-when-loading-the-image-to-the-Image-Editor-/tree/main/OutputImages/AfterResolvingImageRotation.jpg)

To avoid this problem, you can add the image in Android asset folder and refer the image from Android asset to SfImageEditor control as shown in the following screenshot.

![AssetScreenshot](https://github.com/SyncfusionExamples/How-to-resolve-the-default-image-rotation-issue-when-loading-the-image-to-the-Image-Editor-/tree/main/OutputImages/AssetScreenshot.png)

Please refer the following steps to resolve the image rotation at load time.

Step 1: Create SfImageEditor sample with all necessary assemblies.
 
Please refer the following link to create a simple SfImageEditor sample along with the ways to configure it.
 
https://help.syncfusion.com/xamarin/sfimageeditor/getting-started

Step2: Initialize the SfImageEditor control as shown in the following code sample.

**[XAML]**

```
        <imageeditor:SfImageEditor x:Name="editor"/>
```
Step3: Set an image to the SfImageEditor control with platform specific code.

**[C#]**

```
            ...

            if (Device.RuntimePlatform == "Android")
                editor.Source = ImageSource.FromFile("test.jpg");
            else
                editor.Source = ImageSource.FromResource("ImageEditor_Sample.test.jpg");

            ...
```

## See also
 
[Toolbar Customization in Xamarin Image Editor (SfImageEditor)](https://help.syncfusion.com/xamarin/image-editor/toolbarcustomization)
 
[Custom View in Xamarin Image Editor (SfImageEditor)](https://help.syncfusion.com/xamarin/image-editor/customview)
 
[Image Filter in Xamarin Image Editor (SfImageEditor)])(https://help.syncfusion.com/xamarin/image-editor/imagefilter)
 
[Customize text with TextSettings in Xamarin Image Editor (SfImageEditor)](https://help.syncfusion.com/xamarin/image-editor/text#customize-text-with-textsettings)


