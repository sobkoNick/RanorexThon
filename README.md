# RanorexThon

10 tests created: 8 pass and 2 fail because of a bug with product ordering.
4 user stories covered.

User stories covered:
1. Image recognition in Web and Native application;
2. Login to a Web and Native application with autentification by email;
3. Boundary value test.
4. About us story test.

app-release.apk is AUT.
Avd emulator device must have API 24 or higher.
To deploy this app to device you should firstly install Ranorex Services app, which is used to connect Ranorex Studio with your device.
Than open Ranorex Instrumentation Wizard, choose Android, in Install APK section browse to app-release.apk and specify Target Device.

In Ranorex Studio you can run test separetly, in test case or as a whole test suite.
After tests were executed Ranorex forms report with information about test duration, total warings/errors occured, screenshoots taken and test steps executed.
In Reports folder you can find all information about tests including reports, screenshoots, logs and other useful information.

If you want to run this project in Visual Studio, perform next steps:
1. File -> Open Project.
2. Specify path to project.
3. Press "Start" to run a test suite. Yes, that simple))

All tests created in Ranorex Studio by REX team during Mobile Automation Hackathon.
REX team members: Mihailo Tsiganko, Mykola Sobko and Nazar Khimin.