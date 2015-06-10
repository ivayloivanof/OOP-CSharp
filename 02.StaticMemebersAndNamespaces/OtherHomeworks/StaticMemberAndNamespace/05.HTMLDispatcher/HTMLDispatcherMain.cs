/*Write a class ElementBuilder that creates HTML elements:
•	The class constructor should take the element's name as argument.
•	Write a method AddAtribute(attribute, value) that adds an attribute and value to the element. For example, we create an element a and add the attributes href="www.softuni.bg" and class="links". The result is <a href="www.softuni.bg" class="links"><a/>.
•	Write a method AddContent(string) that inserts content inside the current tag (e.g. <div>Text</div>).
•	Overload the * operator for ElementBuilder objects. The operator should multiply the string value of the element n times and return the result as string. (e.g. <li></li> * 3 = <li></li><li></li><li></li>).
Write a static class HTMLDispatcher that holds 3 static methods: CreateImage(), CreateURL(), CreateInput(), which take a set of arguments and return the HTML element as string. Use the ElementBuilder class.
•	CreateImage() takes image source, alt and title.
•	CreateURL() tekes url, title and text.
•	CreateInput() takes input type, name and value.
Test the HTML Dispatcher by creating various HTML elements, using the implemented static methods.*/

namespace _05.HTMLDispatcher
    {
    using System;

    public class HtmlDispatcherMain
        {
        public static void Main()
            {
            try
                {
                ElementBuilder div = new ElementBuilder("div");

                div.AddAttribute("id", "page");
                div.AddAttribute("class", "big");
                div.AddContent("<p>Hello</p>");

                Console.WriteLine(div * 2);

                string url = HTMLDispatcher.CreateURL("www.gmail.com", "Gmail", "Link to gmail.com");
                string image = HTMLDispatcher.CreateImage("c://image.jpg", "some image", "Image");
                string input = HTMLDispatcher.CreateInput("text", "username", "user");

                Console.WriteLine(url);
                Console.WriteLine(image);
                Console.WriteLine(input);
                }
            catch (ArgumentNullException ex)
                {
                Console.WriteLine(ex);
                }
            }
        }
    }
