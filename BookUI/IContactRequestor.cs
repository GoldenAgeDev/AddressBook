using BookLibrary.Models;

namespace BookUI
{
    public interface IContactRequestor
    {
        void ContactComplete(ContactModel contact);
    }
}
