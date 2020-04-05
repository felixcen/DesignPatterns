using System;

namespace DesignPatterns.Builder
{
    /// <summary>
    /// Builder class to construct HTML elements
    /// </summary>
    public class HtmlBuilder
    {
        private readonly string _rootName;
        HtmlElement _rootElement = new HtmlElement();

        public HtmlBuilder(string rootName)
        {
            _rootName = rootName;
            _rootElement.Name = rootName;
        }
 
        public HtmlBuilder AddChild(string childName, string childText)
        {
            var element = new HtmlElement(childName, childText);
            _rootElement.Elements.Add(element);
            return this;
        }
         
        public override string ToString()
        {
            return _rootElement.ToString();
        }

        public void Clear()
        {
            _rootElement = new HtmlElement { Name = _rootName };
        } 
    } 
}
