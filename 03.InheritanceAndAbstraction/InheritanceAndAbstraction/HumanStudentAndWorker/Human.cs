using System;

namespace HumanStudentAndWorker
{
    abstract class Human
    {

        private string firstName;
        private string lastName;

        protected string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                    throw new ArgumentNullException();
                this.firstName = value.Trim();
            }
        }

        protected string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                    throw new ArgumentNullException();
                this.lastName = value.Trim();
            }
        }
    }
}
