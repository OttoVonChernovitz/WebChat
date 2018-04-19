using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebChat.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WebChat.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<ApplicationUser> UsersRepo { get; }
        IBaseRepository<FriendRequest> RequestsRepo { get; }
        IBaseRepository<Friend> FriendsRepo { get; }
        int Save();
    }
}