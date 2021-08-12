using Calab.IdentityAuto.Data;
using Calab.IdentityAuto.Web.Infrastructure.Mappers.Base;
using Calab.IdentityAuto.Web.ViewModels.AccountViewModels;

namespace Calab.IdentityAuto.Web.Infrastructure.Mappers
{
    /// <summary>
    /// Mapper Configuration for entity Person
    /// </summary>
    public class ApplicationUserProfileMapperConfiguration : MapperConfigurationBase
    {
        /// <inheritdoc />
        public ApplicationUserProfileMapperConfiguration()
        {
            CreateMap<RegisterViewModel, ApplicationUserProfile>()
                .ForAllOtherMembers(x => x.Ignore());
        }
    }
}