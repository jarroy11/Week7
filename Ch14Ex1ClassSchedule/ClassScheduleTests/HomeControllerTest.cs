namespace ClassScheduleTests
{
    public class HomeControllerTest
    {
        [Fact]
        public void IndexActionMethod_ReturnsAViewResult()
        {
            var classRep = new Mock<IRepository<Class>>();
            var daysRep = new Mock<IRepository<Day>>();
            var controller = new HomeController(classRep.Object, daysRep.Object);

            var result = controller.Index(0);

            Assert.IsType<ViewResult>(result);
        }
    }
}