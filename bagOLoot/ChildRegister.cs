using System.Collections.Generic;

namespace bagOLoot
{
    public class ChildRegister
    {
        private List<Child> _register = new List<Child>();
        public List<Child> GetRegister()
        {
            return _register;
        }
        public void AddChild(Child child)
        {
            _register.Add(child);
        }
        public void RemoveChild(Child child)
        {
            _register.Remove(child);
        }        
    }
}