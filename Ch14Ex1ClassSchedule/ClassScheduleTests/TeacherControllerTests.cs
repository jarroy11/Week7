namespace ClassScheduleTests
{
    public class TeacherControllerTests
    {
        [Fact]
        public void IndexActionMethod_ReturnsAViewResult()
        {
            var rep = new Mock<IRepository<Teacher>>();
            var controller = new TeacherController(rep.Object);

            var result = controller.Index();

            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void IndexActionMethod_ModelIsAListOfTeacherObjects()
        {
            var rep = new Mock<IRepository<Teacher>>();
            rep.Setup(m => m.List(It.IsAny<QueryOptions<TeacherControllerTests>>()))
                 .Returns(new List<TeacherControllerTests>());
            var controller = new TeacherController(rep.Object);

            var model = controller.Index().ViewData.Model;

            Assert.IsType<List<TeacherControllerTests>>(model);
        }
    }
}