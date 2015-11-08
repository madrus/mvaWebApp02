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