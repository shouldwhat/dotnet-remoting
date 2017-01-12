using System;

namespace Model
{
    public enum SEX
    {
        MAIL,
        FEMAIL
    }

    public enum POSITION
    {
        STAFF,
        ASSISTANT_MANAGER,
        MANAGER,
        GENERAL_MANAGER
    }
    [Serializable]
    public class User
    {
        public String Name { get; set; }
        public String Age { get; set; }
        public SEX Sex { get; set; }

        public POSITION Position { get; set; }

        public override string ToString()
        {
            return String.Format("Name = {0}, Age = {1}, Sex = {2}, Posotion = {3}", Name, Age, Sex, Position);
        }
    }
}
