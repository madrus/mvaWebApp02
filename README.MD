Course Notes
============
WebApp02
--------
### Startup.cs
This is the first file that gets executed

* CONSTRUCTOR gets made
* CONFIGURESERVICES()  
  * where things you might want to use
    * ADD() stuff
      * ADDMVC()
    
* CONFIGURE()  
  * USE() stuff that you made available
    * USEMVC()
    
### Config data
* Json, Ini, Env, ???
* Configuration -> objects! "app options"
* Model Binding for Config
  * (just like when HTTP POST became a Person  
    config.json becomes an option)
* Some Config is "private"
  * User level RATHER THAN THE PROJECT LEVEL
  * "keep people from checking in secrets"
* Environments
  * Development, Staging and Production are known env
  * but as many as you want

### _Layout.cshtml
`<environment names="Development"></environment>` tags let us include snippets 
that should run only in the specified environment. Notice that **Production** is default.

**NB**  
You may notice the color difference between different `script` tags.
One color indicates that the scripts will be loaded as is from the project folder.
The other color indicates that something should happen to that script first 
before it can be loaded. E.g. it should be fetched from CDN. 
There is specified a condition to check and a fallback.
```html
<script src="https://ajax.aspnetcdn.com/ajax/jquery/jquery-2.1.4.min.js"
    asp-fallback-src="~/lib/jquery/dist/jquery.min.js"
    asp-fallback-test="window.jQuery">
</script>
```

### config.json
This is a configuration file where we could place any custom key-value pairs.
The difference with `web.config` is that `web.config` contain stuff that is necessary
either for the application or for the MVC. `config.json` hold only application
configuration settings.

`config.json` in mentioned in the ConfigurationBuilder in `Startup.cs` in its constructor.

**These settings will be overridden by the standard Windows environment variables
should they have the same name. That is the way the Production environment 
can be configured independent of the Development one.**

Adding `.AddEnvironmentVariables();` to the `Startup.cs` makes that it works in this way.

We can also create several `config.json` files per environment.

### secrets.json
If you right click on the project and choose "Manage User Secrets" menu option,
this file will be created or opened.

## Publishing the website
There are two main options to publishing our website: to the file system and to Azure cloud.

### Publishing to the file system
Choose any name for your profile, e.g. Test and by Settings put both checkmarks:

    Settings
        File Publish Options
            - Delete all existing files prior to publish
            - Compile source files into NuGet packages

Now you can go to the project directory and you will find a lot of new stuff
inside the artifacts folder (if you have chose the default publishing path):

* `artifacts/bin/[project name]/Release/PublishOutput/wwwroot`
* `artifacts/bin/[project name]/Release/PublishOutput/approot`

Now you can FTP both folders to your hosting provider. The website itself
is inside the `wwwroot` folder. And all the packages and run commands are 
inside the `approot` folder. It is also possible to run the website by 
dubble clicking on e.g. web.cmd.

### Publishing to the Azure cloud
Choose a new Azure profile (e.g. mvawithglenn) for your website and no database.

That's it! 

When your website is published, the browser will automatically start and open it.

### Free Azure trials
* a free trial account for 1 month with $200 on credit
* a free [sandbox website](https://trywebsites.azurewebsites.net/)


