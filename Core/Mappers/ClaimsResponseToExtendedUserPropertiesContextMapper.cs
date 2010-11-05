﻿using DotNetOpenAuth.OpenId.Extensions.SimpleRegistration;
using NGM.OpenAuthentication.Models;
using Orchard;

namespace NGM.OpenAuthentication.Core.Mappers {
    public class ClaimsResponseToExtendedUserPropertiesContextMapper : IMapper<ClaimsResponse, ExtendedUserPropertiesContext> {
        public ExtendedUserPropertiesContext Map(ClaimsResponse source) {
            var context = new ExtendedUserPropertiesContext();
            if (source.Gender.HasValue)
                context.Gender = source.Gender.Value.ToString();

            return context;
        }
    }
}