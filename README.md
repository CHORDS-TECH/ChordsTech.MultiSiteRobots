# ChordsTech.MultiSiteRobots
A simple lightweight .Net solution for websites which need easy management of multiple robots.txt

Once you have the ChordsTech.MultiSiteRobots.dll downloaded, simply add the following line to start intercepting robots.txt file requests.
```xml
<system.webServer>
   <handlers accessPolicy="Read, Write, Script, Execute">      
	  <remove name="ChordsTech.MultiSiteRobots" />
      <add name="ChordsTech.MultiSiteRobots" verb="*" path="/robots.txt" type="ChordsTech.MultiSiteRobots.RobotsTxt" />
    </handlers>
</system.webServer>
```
You can then add robots.txt files for all your domains e.g:

chordstech.com.robots.txt

staging.chordstech.com.robots.txt

another-site.com.robots.txt

The code will intercept the robots.txt request and match the domain to the correct robots.txt file.
