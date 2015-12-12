# .NET COM+ Sample
* .NET COM+ application with configuration file support

# Key Points
* System.EnterpriseServices library has been added to make it a COM+ application
* GUID has been applied to the class. guidgen.exe utility has been used to create the GUID.
* guidgen.exe path: %Installation Path%\Microsoft Visual Studio 11.0\Common7\Tools\guidgen.exe
* ComVisible has been added to the class header. If more granularity is wanted, ComVisible can be applied to the methods inside the class
* application.manifest and application.config has been added to the project to use configuration capability of .NET
* DotNetComPlusCategory has been created as a server application in COM+ applications.
* This category must have "Authenticated Users" in the roles section.
* This category's Application Root Directory has been set to the directory where application.manifest and application.config files reside.
* Otherwise COM+ manager can not reach to the configuration file.
* Strong name has been created without a password since this is a demo application.
* If no strong name defined, the dll can not be added to the COM+ manager.
* Strong name key: skyfall
* Strong names can be created from "Project properties -> Signing". Select sign the assembly and select new.
