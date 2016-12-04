﻿namespace AngleSharp.Css.Dom
{
    using AngleSharp.Dom;
    using System;

    sealed class AttrAvailableSelector : BaseAttrSelector, ISelector
    {
        public AttrAvailableSelector(String name, String prefix)
            : base(name, prefix)
        {
        }

        public String Text
        {
            get { return String.Concat("[", Attribute, "]"); }
        }

        public void Accept(ISelectorVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public Boolean Match(IElement element, IElement scope)
        {
            return element.HasAttribute(Name);
        }
    }
}
