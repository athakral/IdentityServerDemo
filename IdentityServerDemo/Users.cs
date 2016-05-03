using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using IdentityServer3.Core;
using IdentityServer3.Core.Services.InMemory;

namespace IdentityServerDemo {
    public static class Users {
        public static List<InMemoryUser> Get() {
            return new List<InMemoryUser> {
                new InMemoryUser {
                    Subject = "1",
                    Username = "test",
                    Password = "pass",
                    Claims = new List<Claim> {
                        new Claim(Constants.ClaimTypes.GivenName, "Test"),
                        new Claim(Constants.ClaimTypes.FamilyName, "User"),
                        new Claim(Constants.ClaimTypes.Email, "test.user@gmail.com")
                    }
                }
            };
        }
    }
}