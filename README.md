# ft-xam-FanaticalApp

This mobile app on iOS and Android will be used for demo purpose of [FanaticalTest factory](https://github.com/FanaticalTest/ft-test-mobile-factory-demo).<br />
<br />
For the demo we will have a unique app for both plateform and reduce the test script developement.<br />

## Manual release
The version update is done for the moment manually. So you will need to update the following files :
* `/FanaticalApp/Properties/AssemblyInfo.cs`
```
[assembly: AssemblyVersion("1.0.0")]
```
* `/FanaticalApp.iOS/info.plist`:
..* Identity > Version : set the version number
..* Identity > Build : Increment +1
* `/FanaticalApp.Droid/Properties/AssemblyInfo.cs`
```
[assembly: AssemblyVersion("1.0.0")]
```
* `/FanaticalApp.Droid/Properties/AndroidManifest.xml`
..* Increment +1 to Version number or android:versionCode
..* Set the version to Version name or android:versionName
* `/FanaticalApp/Config.xaml`<br />
Update the Text field of the lable `textVersionValue`