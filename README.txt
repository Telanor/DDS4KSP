-------------
---DDS4KSP---
-------------

The purpose of this program is to convert the maximum of textures from the GameData folder into dds, DXT-compressed format, to enjoy reduced loading times, thanks to DDSLoader, by Sarbian.
As he's not involved in the development of this program, please PM reports and log file directly to me (Lilleman). His plugin is working great, so no need to bother him with my mistakes.

It works by looking for every MBM, TGA, and PNG files in a selected folder, and converting them in DXT1/DXT5/DXT5nm format. While those are compressed images format, there should not be major
quality loss in the process. Format is chosen automatically, depending on the original file format. But you can also decide to apply a custom configuration before a conversion (single file or folder).
The final goal for this program is having him being be able to convert any possible mods textures flawlessly.
Unfortunately, that's not the case yet. As Active Texture Management, some exceptions and special configurations need to be setted. They are are stored in a file called ModsExceptions.txt.
This file should be located in the same folder as the executable. As this program is quite young, I tested some popular mods, and actualize the exceptions list accordingly, but I didn't test all of them.

I expect you to know what textures conversion implies, and to keep a backup of your mods folder in case anything goes wrong. This program is still in a "Work In Progress" state.
That being said, it should recognize ARGB8/RGB8 TGA and PNG files, and MBM conversion is working well. Some indexed image formats are not handled yet. I'm still wondering if there's any purpose
for converting those, but I'm still trying to have them converted anyway, it's just a matter of time...
Those formats are P8, L8, A8L8, L16,as far as I can tell. Those are already quite efficient file formats, and I don't know if there will be any benefits for converting them. Investigation is in progress...

This program can convert a single file or a whole folder in a single batch. If you're converting a single file, the ModsExceptions.txt file will not be acknowledged.
Parameters should be detected automatically when you convert a file, but you can still force some parameters before launching a batch. If you need any argument to be added, or if you
find new exceptions to be added, please let me know.

I don't expect this program to have a very long life: modders will probably learn about DDSLoader soon or later and convert their files by themself. But for the time being, I would like it to be as complete as possible.
And to be able to convert as much mods as possible without having to add some custom exceptions.

Some mods are hard-coded to look for a specific file format. Keep an eye on the KSP log window to see if an exception is thrown when loading a texture.

Note: 
-TGA and PNG files are flipped automatically during a conversion.
-To avoid toolbar's icons to become too blurry, images with a resolution lower than 64 (width or height) will be saved in an uncompressed file format (RGB8 or ARGB8, depending on the original file). This value is hard-coded for now, but let me know if I should have an option to modify it.
-Files with a resolution lower than 8 (width or height) will not be converted. You can change this value, but 8 is the minimum. (again, let me know if I should change this)
-This program also provide the option to resize every texture, with 1, 3/4, 1/2, and 1/4 ratios. It applies the same ratio for textures and normalmaps. Upscaling with filter (2xSAI, Eagle, HQ3X, HQ4X) has been experimented, but quality is not as good as expected, so if I implement this option, it'll be after solving other problems.
-You can specify a minimal size for resizing. Smaller textures will be saved in their original resolutions. This option is only relevant if you use a rescaling ratio lower than 1.
-If you use the "Force normal" argument on a file, it will be flagged as a normal. MBM files just have a byte modified, but TGA and PNG files are "swizzled" to xGxR format in the process.


You could probably have the same results, if not better, if you write your own batch file for nvdxt or Crunch (two efficient dds converters). But if you want to spent some time to help me improve this tool, I coudn't thank you enough.

Again, you can PM me directly if you encounter any problem with this program or if you have any execption that need to be added to the ModsExceptions list. If you're familiar with managed DirectX, and know how to convert indexed images formats correctly PLEASE let me know.


Planned features:
-Better folder browser window (I've found a snippet for it, I just didn't have enough time to implement this for this release).
-Support for more file formats.
-Exporting mbm files to other formats than DDS.
-Cross-platform support if there's demand for it.


Thanks for reading all this!


Lilleman.
