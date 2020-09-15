# Clean Service Registration
Clean way of registering services in asp net core 3.1 web api application.

- Add all files like in [installers](/CleanServiceRegistration/Installers)
- In [Setup.cs](/CleanServiceRegistration/Startup.cs) add one line:
```charp
services.AddServicesInAssembly(Configuration);
```

- For registering new services just create new chsarp file that inherits [IInstaller.cs](/CleanServiceRegistration/Installers/IInstaller.cs) and implement it.
