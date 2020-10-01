# Markdown File

# IsMultipleOf.API v1

Use case of ASP.NET Core API v3.1.

This API calculate if each element of an array of numbers is multiple of a specific divisor.

1. Clone.
2. Open the solution (_IsMultipleOf.API.sln_ file) with Visual Studio 2019 (version 16.4 or greater).
3. Use the _Test Explorer_ to run the tests.
4. Press _F5_ to start the API.
5. Use the swagger interface loaded to test the API:
   - Expand the _[POST] /IsMultipleOf/\{divisor}_ panel. 
   - Press the button _Try it out_.
   - Set the _divisor_ value in the field, for example _11_.
   - Set the _request body_, for example: ```{ "numbers": [112233, 30800, 2937, 323455693, 5038297, 112234] }```
   - Press the button _Execute_.
   - Chack the response.
