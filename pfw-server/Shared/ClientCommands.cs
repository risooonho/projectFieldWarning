using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    public enum LobbyCommand
    {
        AllowJoin,
        RefuseJoin,
        Invite,
        Kick,
        Ban,
        //view_info?

    }

    public enum SocialCommand
    {
        FriendRequest,
        BlockNotify,
        PmNotify
    }

    public enum InGameCommand
    {

    }
}
