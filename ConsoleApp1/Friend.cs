using System;
using System.Collections.Generic;

public class Friend
{
    public string Email { get; private set; }

    public ICollection<Friend> Friends { get; private set; }

    public Friend(string email)
    {
        this.Email = email;
        this.Friends = new List<Friend>();
    }

    public void AddFriendship(Friend friend)
    {
        this.Friends.Add(friend);
        friend.Friends.Add(this);
    }

    public bool CanBeConnected(Friend friend)
    {
        return !this.Friends.Contains(friend);

    }
}