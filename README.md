# Alschy.Blazor.Sieve

![Build status](https://alschy.visualstudio.com/Alschy.Blazor.Sieve/_apis/build/status/Alschy.Blazor.Sieve-CI)  
![Nuget](https://img.shields.io/nuget/v/Alschy.Blazor.Sieve.svg)

## General
This project is a client implementation for Microsoft Blazor Apps for the [Sieve](https://github.com/Biarity/Sieve) Project.
Its provide a Taghelper for a Grid which can dynamically create a HTML Table who support column filtering, column sorts and pagination. Default UI is styled for Bootstrap in the version 4.3, in additon the open ionic icons used for the sort arrows. The classes can be overriden by HTML parameter to set a custom styling. Some more came if the code is added ;) 

## Installation 
The Package is aviable on NuGet. The current version is ![Nuget](https://img.shields.io/nuget/v/Alschy.Blazor.Sieve.svg)  
For run in a Package-Manager consol run this command

```
PM>Install-Package Alschy.Blazor.Sieve 
```

## The HTML

To use the table is only a single tag requiered:

``` HTML
<BlazorGrid></BlazorGrid>
``` 
 To work are any parameters required this are in the follow table with a * signed
 
<table>
  <tr>
    <th>Name</th>
    <th>Type</th>
    <th>Default</th>
    <th>Comment</th>
  </tr>
  <tr>
    <td>TableItem*</td>
    <td><pre lang="csharp">Type</pre></td>
    <td/>
    <td>The type of the elements in the table</td>
  </tr>
  <tr>
    <td>QueryPath*</td>
    <td><pre lang="csharp">string</pre></td>
    <td></td>
    <td>A path to an route who accept the SieveModel as query paramters</td>
  </tr>
  <tr>
    <td>ColumnDefinitions*</td>
    <td><pre lang="csharp">IEnumerable&lt;ColumnDefinition&gt;</pre></td>
    <td></td>
    <td>A collection of ColumnDefinitions which is needed to initialize the table with there content</td>
  </tr>
  <tr>
    <td>TableFrameClass</td>
    <td><pre lang="csharp">string</pre></td>
    <td><pre>table-responsive</pre></td>
    <td>The class for div element around the table</td>
  </tr>
  <tr>
    <td>TableClass</td>
    <td><pre lang="csharp">string</pre></td>
    <td><pre>table table-hover</pre></td>
    <td>The class for the table element.</td>
  </tr>
  <tr>
    <td>ColumnFilterInputClass</td>
    <td><pre lang="csharp">string</pre></td>
    <td><pre>form-control</pre></td>
    <td>The class for the input for the column filters</td>
  </tr>
  <tr>
    <td>SortAscSpanClass</td>
    <td><pre lang="csharp">string</pre></td>
    <td><pre>oi oi-arrow-top</pre></td>
    <td>The icon who is display if a column ascending sorted</td>
  </tr>
  <tr>
    <td>SortDescSpanClass</td>
    <td><pre lang="csharp">string</pre></td>
    <td><pre>oi oi-arrow-bottom</pre></td>
    <td>The icon who is display if a column descending sorted</td>
  </tr>
  <tr>
    <td>FilterVisable</td>
    <td><pre lang="csharp">bool</pre></td>
    <td><pre>false</pre></td>
    <td>say if the column filter inputs are visable. Value can changed on program run</td>
  </tr>
  <tr>
    <td>PageSize</td>
    <td><pre lang="csharp">int?</pre></td>
    <td><pre>null</pre></td>
    <td>Set the pagesize they will load on the next reload. If it null pagination is diabled. On dev! Value can changed on program run</td>
  </tr>
  <tr>
    <td>CurrentPage</td>
    <td><pre lang="csharp">int?</pre></td>
    <td><pre>null</pre></td>
    <td>The current page if pageination enabled. If value is null pagination is diasbled. On dev! Value can changed on programm run</td>
  </tr>
</table>

## The code
will come soon! :)



Feel free to contribute, using (too in comercial applications) and fork. Its MIT Licensed 
