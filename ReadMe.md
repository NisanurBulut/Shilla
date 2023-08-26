﻿
# Magic Shilla App 

<3 I have missed the code Net core 

## Give a Star! :star:
If you like or are using this project to learn or start your solution, please give it a star. Thanks!


<hr/>

### Technical Dictionary
* Binding Parameters in Asp.Net MVC

<ol>
<li>FromQuery : <p> This type contains query items. To use them,  we need to read parameters 
from URL address and we need to check <b>?</b> character.
Example <i>https://example.com/api/products?id=123&name=keyboard</i>

<code>
[HttpGet("products")]
public IActionResult GetProduct([FromQuery] int id, [FromQuery] string name)
{

}
</code>

</p>
</li>
<li>FromBody : <p> This type uses data inside of HTTP Body. it generally used for <b>POST, PUT or PATCH</b> requests.
Kind of data might be JSON, XML or another type.
</p>

<code>
[HttpPost("products")]
public IActionResult CreateProduct([FromBody] ProductDto productDto)
{
   
}
</code>
</li>
<li>FromRoute : <p>It is used to bind routing parameters in the URL to a parameter in the API method. Redirect parameters are dynamic values specified in a specific part of the URL.
Example <i>https://example.com/api/products/{id}</i> It is commonly used when reading resource id information.
</p>
<code>
[HttpGet("products/{id}")]
public IActionResult GetProductById([FromRoute] int id)
{
}
</code>
</li>
</ol>

* Validation

[Validation Diagram](/MagicCity_ShillaAPI/asset/model_state_diagram.png)

<hr/>