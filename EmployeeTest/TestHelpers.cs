using AutoFixture;
namespace EmployeeTest
{
    public static class TestHelpers
    {
        public static T CreateObject<T>() where T : class
        {
            Fixture fixture = new Fixture();
            var obj = fixture.Build<T>()
                .WithAutoProperties().Create();

            return obj;
        }
    }
}
