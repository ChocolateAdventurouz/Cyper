# Cyper's Update Patch
Cyper's Update Patch is a small compressed file (.cupkg) that contains the latest changes on the base app and componets. 
It is useful for users who don't like downloading big setup files or don't want to overwrite the current installation. Cool, right?

Cyper.exe is associcated with this file type during installation.


How big is the package?

It depends on the changelog. It will more likely be from some KiloBytes to some MegaBytes.

What makes it small in comparison with the setup?

A base setup contains some python libraries that they will be updated rarely. Also the installer itself which contains images, icons and commands can take a bunch of space.
On the other hand, Cyper's Update Patch contains ONLY the latest changes to some componets, and not necessary python libraries or componets that they haven't changed.
These files can be obtained by Sourceforge, GitHub, and on the Update and Repair page on Cyper as well.

Ways to install:

1. Cyper's Update page (Recommended)
2. Command Prompt (Do it at your own risk)

WARNING! 
Command Prompt way DOES NOT have version check! It is more likely to get a broken installation.

Update using the Update page on Cyper: 
1. Go to the "Update" page in Cyper and press the "Update using a .cupkg file" button

What it does in background?
1. Cyper decompresses the patch on the "update" folder to check a file inside the patch called "__PKGLOCAL__" that contains the version that is going to be installed.
If the patch version is older that the installed version of Cyper, an error code will appear "0725".
2. If the patch is vaild, the executable called "local_updater.exe" kicks in and starts the updating process.

Update using Command Prompt:

THE DOWNLOADED FILE MUST HAVE THIS FILENAME "Q3lwZXIgVXBkYXRlIEZpbGVz.cupkg"
1. Copy the patch file to <Cyper's installation directory>\update
2. Open the command prompt inside Cyper's installation directory or by "cd" <Cyper's installation directory>
3. Finally, type: local_updater.exe /u
4. The updating process will start.

After installation is recommended to clean the temp directory from the app, and delete the patch file from the "update" directory, if you installed the update by using command prompt

In case...

- In case an update patch is broken, you have to install the app. You will be notified by an error code: 0727.

Error codes & meaning

- 0727: Broken Patch is installed. Please re-install the app.
- 0725: The Patch file is outdated. Please obtain the latest patch file.
- 0729: The Installation directory is not found.
- 0722: The Update File is missing or not named correctly.
