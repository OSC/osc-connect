#AweSim Connect Change Log

All notable changes to this project will be documented in this file. This project adheres to [Assembly Versioning](https://msdn.microsoft.com/en-us/library/51ket42z(v=vs.71).aspx).

## v0.96

* Clears up some overlapping code in the app configuration file
* Properly initializes username and password fields from variables to prevent change event handlers from wiping state.

## v0.95

* Add Owens cluster as default.
* Saved password updates on change.
* Fix version checking bug.
* Fix hang when cluster non-responsive.
* Update to PuTTY/Plink 0.69
* Update to TurboVNC 2.1.1
* Update to WinSCP 5.9.5

## v0.94

* Version checker links to the correct updated binary at Github.

## v0.93

* Provide dynamic branding.

## v0.92

* Only launch VNC with /quality flag when not default.
* Rebrand to OSC Connect
* Add `osc://` uri handler.
* Bug fixes and refactorings.
* Update PuTTY/Plink to 0.67
* Update TurboVNC to 2.0.91
* Update WinSCP to 5.7.7
* Modified app to use github for releases and binaries
* Update Newtonsoft.JSON to 8.0.3

## v0.90

* Only bring window to front when username is empty.
* Error handling around all Win32 calls.
* Add slider to adjust default VNC quality.
* Add SFTP to URI scheme.
* Uri encode sftp password on launch.

## v0.80

* Update to TurboVNC 2.0.1
* Update PuTTY/Plink to 0.66
* Update WinSCP to 5.7.6
* Version check update.
* Error handling when unable to write folder.
* Deploy helper apps to temp location.
* Disable WinSCP update nag.

## v0.71

* Allow dynamic COMSOL ports.
* Bug fixes.

## v0.70

* One-click connect via URI is now the default behavior.
* Switch plink to PuTTY tunnel to provide GUI RSH key accept notification.
* Little windows disappear on connect now.
* Update WinSCP to 5.7.5
* WinSCP now connects to 'sftp.osc.edu' by default.
* Version checking enabled.
* Clipboard behavior disabled by default.

## v0.61

* Connection windows now spawn to the right of the main form.
* All child windows are brought to fore when app is activated.
* Fix bug with multiple windows to the same point not maintaining connection properly.
* Remove FileZilla handling and use WinSCP by default.
* Add the time launched to the optional panel window.
* Compiler updated to .NET Native for improved performance. (VS2015)

## v0.60

* Add support for clickable awesim:// links.
* Clean up deployed resources and processes on close.
* PuTTY version update.
* Optimizations and bug fixes.

## v0.51

* Fix bug where app doesn't deploy to subfolder when existing in base folder.

## v0.50

* UI Revamp
* Bug Fixes
* Performance improvements
* Single-instancing
* Add basic SSH check if telnet status changes
* Add terminal emulation via PuTTY
* All helper apps now save to PATH/AweSimFiles/
* Application accepts and parses command line args
* Application accepts and parses awesim:// string
* Add optional advanced setting for automated click

## v0.43

* Add WinSCP as embedded resource and SFTP client fallback.

## v0.42

* Remove giant x
* Enable clipboard by default
* Advanced settings tooltips

## v0.41

* Advanced settings bug fix

## v0.3

* Add support for visualization nodes
* Changed default vnc client from ggivnc to TurboVNC 1.2.9beta (for improved performance and support for screen resizing)
* Local port mapping to prevent multiple tunnel overlap
* Better handling of clipboard data
* Process management improvements
* General bug fixes
