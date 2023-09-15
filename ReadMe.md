﻿
# Magic Shilla App 📌 On Going

❤ I have missed the code Net core 

## Give a Star! :star:
If you like or are using this project to learn or start your solution, please give it a star. Thanks!


<hr/>

![](/MagicCity_ShillaWEB/wwwroot/assets/img/login_page.png)
![](/MagicCity_ShillaWEB/wwwroot/assets/img/back1.PNG)
![](/MagicCity_ShillaWEB/wwwroot/assets/img/register_page.png)

<hr/>

### Technical Dictionary
🧨 Binding Parameters in Asp.Net MVC

<ol>
<li>FromQuery : <p> This type contains query items. To use them,  we need to read parameters 
from URL address and we need to check <b>?</b> character.
Example <i>https://example.com/api/products?id=123&name=keyboard</i>

```C#
[HttpGet("products")]
public IActionResult GetProduct([FromQuery] int id, [FromQuery] string name)
{

}
```

</p>
</li>
<li>FromBody : <p> This type uses data inside of HTTP Body. it generally used for <b>POST, PUT or PATCH</b> requests.
Kind of data might be JSON, XML or another type.
</p>

```C#
[HttpPost("products")]
public IActionResult CreateProduct([FromBody] ProductDto productDto)
{
   
}
```
</li>
<li>FromRoute : <p>It is used to bind routing parameters in the URL to a parameter in the API method. Redirect parameters are dynamic values specified in a specific part of the URL.
Example <i>https://example.com/api/products/{id}</i> It is commonly used when reading resource id information.
</p>

```C#
[HttpGet("products/{id}")]
public IActionResult GetProductById([FromRoute] int id)
{
}
```
</li>
</ol>

🧨 Validation

![Validation Diagram](/MagicCity_ShillaAPI/asset/model_state_diagram.png)

🧨 Region Directive

I am particularly fond of 😻 the <code>#region</code> directive. It allows us to collapse code in a customized manor.
Regions are created in this format,


```C#
#region NisanurStartedCoding
return Ok(👌);
#endregion
```
Benefits of using region director :
<ul role="list" style="list-style: square;">
  <li>Well organized</li>
  <li>easily readable</li>
  <li>code can be easily navigated</li>
  <li>increade efficiency</li>
</ul>

<hr/>


### Dapper vs Entity FrameWork

![Dapper v/s Entity Framework(Core) https://www.youtube.com/watch?v=ialFGpKD8yI](/MagicCity_ShillaAPI/asset/dapper_ef.png)



### IEnumerable vs IQueryable
![Dapper v/s Entity FrameWork](/MagicCity_ShillaAPI/asset/ie_iq.png)

<hr/>
🧨 Differences Between Scoped, Transient, And Singleton Service

<p><strong>Why we require</strong></p>

<ul>
	<li>It defines the lifetime of object creation or a registration&nbsp;in the .net core with the help of Dependency Injection.</li>
	<li>The DI Container has to decide whether to return a new object of the service or consume an existing instance.</li>
	<li>The lifetime of the Service depends on how we instantiate the dependency.</li>
	<li>We define the lifetime when we register the service.</li>
</ul>

<p><strong>Three types of&nbsp;lifetime and registration options</strong></p>

<ol>
	<li><em>Scoped</em></li>
	<li><em>Transient</em></li>
	<li><em>Singleton</em></li>
</ol>

<h2>Scoped</h2>

<ul>
	<li>In this service, with every HTTP request, we get a new instance.</li>
	<li>The same instance is provided for the entire scope of that&nbsp;request.
	<ul>
		<li>eg., if we have a couple of parameter in the controller, both object contains the same instance across the request</li>
	</ul>
	</li>
	<li>This is a better option when you want to maintain a state within a request.</li>
</ul>

<div class="code-toolbar"><pre class="language-csharp line-numbers" tabindex="0">
<code class="language-csharp">services<span class="token punctuation">.</span><span class="token generic-method"><span class="token function">AddScoped</span><span class="token generic class-name"><span class="token punctuation">&lt;</span>IAuthService<span class="token punctuation">,</span>AuthService<span class="token punctuation">&gt;</span></span></span><span class="token punctuation">(</span><span class="token punctuation">)</span><span class="token punctuation">;</span><span aria-hidden="true" class="line-numbers-rows"><span></span></span></code>
</div>

<p style="text-align:center"><img alt="" class="" data-src="https://f4n3x6c5.stackpathcdn.com/article/differences-between-scoped-transient-and-singleton-service/Images/scoped_service.PNG" style="height:245px; width:800px" src="https://f4n3x6c5.stackpathcdn.com/article/differences-between-scoped-transient-and-singleton-service/Images/scoped_service.PNG"></p>

<h2>Transient</h2>

<ul>
	<li>A new service instance is created for each object in the HTTP request.</li>
	<li>This is a good approach for the multithreading approach because both objects are independent of one another.</li>
	<li>The instance is&nbsp;created every time they will use&nbsp;<strong>more memory</strong>&nbsp;and <strong>resources </strong>and can have a&nbsp;<strong>negative</strong>&nbsp;impact on performance</li>
	<li>Utilize for the&nbsp;<strong>lightweight</strong>&nbsp;service with little or&nbsp;<strong>no state</strong>.</li>
</ul>

<div class="code-toolbar"><pre class="language-csharp line-numbers" tabindex="0"><code class="language-csharp">services<span class="token punctuation">.</span><span class="token generic-method"><span class="token function">AddTransient</span><span class="token generic class-name"><span class="token punctuation">&lt;</span>ICronJobService<span class="token punctuation">,</span>CronJobService<span class="token punctuation">&gt;</span></span></span><span class="token punctuation">(</span><span class="token punctuation">)</span><span class="token punctuation">;</span><span aria-hidden="true" class="line-numbers-rows"><span></span></span></code>
</div>

<p style="text-align:center"><img alt="" class="" data-src="https://f4n3x6c5.stackpathcdn.com/article/differences-between-scoped-transient-and-singleton-service/Images/tranient_service.PNG" style="height:220px; width:800px" src="https://f4n3x6c5.stackpathcdn.com/article/differences-between-scoped-transient-and-singleton-service/Images/tranient_service.PNG"></p>

<h2>Singleton</h2>

<ul>
	<li>Only one service instance was created throughout the lifetime.</li>
	<li>Reused the same instance in future, wherever the service is required</li>
	<li>Since it's a single lifetime service creation, memory leaks in these services will build up over time.</li>
	<li>Also, it has&nbsp;memory efficient as they are created once reused everywhere.</li>
</ul>

<div class="code-toolbar"><pre class="language-csharp line-numbers" tabindex="0"><code class="language-csharp">services<span class="token punctuation">.</span><span class="token generic-method"><span class="token function">AddSingleton</span><span class="token generic class-name"><span class="token punctuation">&lt;</span>ILoggingService<span class="token punctuation">,</span> LoggingService<span class="token punctuation">&gt;</span></span></span><span class="token punctuation">(</span><span class="token punctuation">)</span><span class="token punctuation">;</span><span aria-hidden="true" class="line-numbers-rows"><span></span></span></code>
</div>

<p style="text-align:center"><img class="" data-src="https://f4n3x6c5.stackpathcdn.com/article/differences-between-scoped-transient-and-singleton-service/Images/image.png" style="height:162px; width:800px" src="https://f4n3x6c5.stackpathcdn.com/article/differences-between-scoped-transient-and-singleton-service/Images/image.png"></p>

<h2>When to use which Service</h2>

<p>Singleton approach =&gt; We can use this for logging service, feature flag(to on and off module while deployment), and email service</p>

<p>Scoped approach =&gt; This is a better option when you want to maintain a state within a request.</p>

<p>Transient approach =&gt;&nbsp; Use this approach&nbsp;for the lightweight service with little or no state.</p>
</div>

<hr/>

🔍 AsNoTracking:

<p>
in scenarios where you only need read-only access to data and don't intend to modify or update it, 
using AsNoTracking can offer performance benefits. </p>

💡 It avoids the overhead of change tracking, resulting in faster query execution.

🔍 AsNoTrackingWithIdentity:

<p>When using AsNoTrackingWithIdentity, EF Core still tracks the identity of entities retrieved from the database.</p>

💡 It is particularly useful when working with scenarios that require a mix of read-only and update operations

📌 Key Differences:

<ul>
<li>AsNoTracking completely disables change tracking, resulting in improved performance for read-only scenarios</li>
<li> AsNoTrackingWithIdentity disables change tracking for most properties, but it keeps track of the entity's identity, 
allowing updates to be applied efficiently when necessary.</li></ul>
🔧 When to Use Which ❓  when should you use each method ❓
<ul>
<li>
Use AsNoTracking when you only require read-only access to entities and want to optimize performance.</li>
<li>Use AsNoTrackingWithIdentity when you need both read-only access and the ability to update specific entities efficiently.</li>
</ul>

<hr/>

<b>Data Transfer Objects</b> are used to transfer data between the <b>Application Layer</b> and <b>the Presentation Layer</b>.

<hr/>

#### 💡 Layouts
Layout actually used to maintain consistency in the web pages and also using this, repetitive code can be reduced. Normally, layout mainly contains header, navigation, menu elements or footer sections.

#### 💡 Partial Views
Partial views mainly reduce code duplicate by maintain reusable parts of the views.

#### 💡 View Components
It is quite similar to the partial view in terms of reusability and reduce code repetition.

<div style='border:1px solid blue; margin-bottom:3px;'>
<ul>
<li><i>View components do not use model binding</i></li>
<li><i>View Component class must be derived from the ViewComponent class.</i></li>
<li><i><b>Like Partial View,</b> View components does not depend on controllers. It has its own class to implement the logic to develop the component’s model and razor markup view page. </i></li>
<li><i>View Components can utilize dependency injection</i></li>
</ul>
</div>

<div style='border:1px solid red; padding-top:3px;'>
<i>Actually, views help us to establish a SOC Design (Separation of Concerns) within the MVC application. 
It basically separates the user interface from other parts of the application. </i>
</div>

<hr/>

<table>
  <tr>
    <th>Packages</th>
    <th>Links</th>
	<th>References</th>
  </tr>
  <tr>
    <td>
	<ol><li> 

[Microsoft.AspNetCore.JsonPatch](https://www.nuget.org/packages/Microsoft.AspNetCore.JsonPatch/7.0.10) </li>
<li> 

[Microsoft.AspNetCore.Mvc.NewtonsoftJson](https://www.nuget.org/packages/Microsoft.AspNetCore.Mvc.NewtonsoftJson/7.0.10) 
</li><li>

[Serilog.AspNetCore](https://www.nuget.org/packages/Serilog.AspNetCore/7.0.0)
</li><li> 

[Serilog.Sinks.File](https://www.nuget.org/packages/Serilog.Sinks.File/5.0.0)
</li><li>

[Microsoft.EntityFrameworkCore.SqlServer](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer/7.0.10)
</li><li>

[Microsoft.EntityFrameworkCore.Tools](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Tools/7.0.10)
</li><li>

[AutoMapper.Extensions.Microsoft.DependencyInjection](https://www.nuget.org/packages/AutoMapper.Extensions.Microsoft.DependencyInjection/12.0.1)
</li><li>

[AutoMapper](https://www.nuget.org/packages/AutoMapper/12.0.1)
</li></ol></td><td><ol><li> 

[What is JSON Patch?](https://jsonpatch.com/) 
</li><li>

[Generate Fake C# Data](https://generatedata.com/generator)
</li><li>

[10-bad-practices-to-avoid-in-aspnet-core-api-controllers](https://dev.to/andytechdev/10-bad-practices-to-avoid-in-aspnet-core-api-controllers-2o9l)
</li></ol></td><td><ol><li> 

[<i>differences-between-scoped-transient-and-singleton-service</i>](https://www.c-sharpcorner.com/article/differences-between-scoped-transient-and-singleton-service/) 
</li><li>

[<i>explaining-difference-between-asnotracking-net-core</i>](https://www.linkedin.com/pulse/explaining-difference-between-asnotracking-net-core-ahad-tagh%C4%B1yev/)
</li><li>

[<i>Data-Transfer-Objects</i>](https://aspnetboilerplate.com/Pages/Documents/Data-Transfer-Objects)
</li><li>

[<i>Dapper v/s Entity Framework(Core)</i>](https://www.youtube.com/watch?v=ialFGpKD8yI)
</li><li>

[<i>IEnumerable vs IQueryable</i>](https://www.youtube.com/watch?v=J2u1DmnE9mU)
</li></ol></td></tr></table>

<hr/>


<table>
  <tr>
    <th>Architecture Patterns</th>
    <th>Speed Up API Performance Methods</th>
  </tr>
  <tr>
    <td>
	<img src="/MagicCity_ShillaAPI/asset/arch_patterns.png" />
	</td>
	<td><img src="/MagicCity_ShillaAPI/asset/increase_api_performance.png" /></td>
	</tr>

</table>

<hr/>

### Swagger Documentation

![swagger_documentation](/MagicCity_ShillaAPI/asset/swagger_documentation.PNG)