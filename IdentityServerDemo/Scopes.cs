﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IdentityServer3.Core.Models;

namespace IdentityServerDemo {
    public static class Scopes {
        public static IEnumerable<Scope> Get() {
            return new List<Scope> {
                StandardScopes.OpenId,
                StandardScopes.Profile,
                StandardScopes.Email
            };
        }
    }
}