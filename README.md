# sBlog.Net Mods

This is just some experimental stuff for sBlog.Net. I already have a branch under sBlog.Net where I am trying to design a plug-in system for sBlog.Net. This repo is dedicated to another way of dealing with additional functionality for a blog engine running sBlog.Net - using http modules. Let's see how it goes!

### How do I enable a module available here?

Here are the steps to enable the use of the counter module.

* Open the sBlog.Net.Mod.Counter project
* Build the project
* Go to the file system that has the "bin" folder, then depending on the configuration (debug | release), identify the folder and open it
* Now copy the sBlog.Net.Mod.Counter.dll and paste it inside the bin folder of your sBlog.Net project

To enable this module, open the web.config file of sBlog.Net and just before </system.web> add the following

```xml
<httpModules>
  <add name="BlogCounter" type="sBlog.Net.Mod.Counter.BlogCounterModule, sBlog.Net.Mod.Counter"/>
</httpModules>
```

That's it! This module is registered and is ready to be used. So when you launch sBlog.Net, every request is passed on to this module and the module does various things to log it!

```text
***Notice***: These features are currently under development
```
