
using BuilderDP;

Director director= new Director();
var newbuilder = new NewPhoneBuilder();
director.PhoneGenerator(newbuilder);
var model = newbuilder.GetData();
Console.WriteLine(model.Brand);