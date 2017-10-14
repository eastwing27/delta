using System;

namespace Delta.Shared.Models
{
    public class Trait<T> : DeltaObject
    {
        public Action<T> Apply {get;set;}
    }
}