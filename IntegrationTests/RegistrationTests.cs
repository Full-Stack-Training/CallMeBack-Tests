using System;
using System.Threading.Tasks;

using Basics.Containers;
using Basics.Domain;
using Basics.Testing.Xunit;

using FullStackTraining.CallMeBack.Domain.Contracts.Interfaces;
using FullStackTraining.CallMeBack.Tests.Shared;

using Xunit;

namespace FullStackTraining.CallMeBack.IntegrationTests
{
    public sealed class RegistrationTests : BaseUserContextTest<ContainerFixture, UserFixture>
    {
        public RegistrationTests(ContainerFixture containerFixture, UserFixture userContextFixture) : base(containerFixture, userContextFixture)
        {
        }

        public IRegistrationDomain Domain => Container.Resolve<IDomainFactory>().Get<IRegistrationDomain>(User.AuthorizedAdmin);

        [Fact]
        public async Task Get_callback_numbers_throws_exception()
        {
            await Assert.ThrowsAsync<NotImplementedException>(() => Domain.GetCallbackNumbers(new[] { Guid.NewGuid() }));
        }
    }
}
