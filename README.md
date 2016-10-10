# ConfigOptionsTest
Test project for troubleshooting ASP.NET Core configuration issue in Azure.

I was fighting with this issue:
 - http://stackoverflow.com/questions/39947431/parsing-config-to-ioptionst-fails-in-azure 
 - https://github.com/aspnet/Configuration/issues/528 
 
I decided to create a test project to see if I could re-produce the issue in a small and more isolated project. I could not.

It turns out that my Azure App Service (Web App) instance that I'd used for a long time were the culprit - in desperation I 
deployed the project that failed in Azure to a new App Service instance and it started working.

I tried to delete a lot of folders using [Kudu](https://github.com/projectkudu/kudu) but it didn't work.

I ended up deleting the App Service instance I was using in favor of a newly created one.
