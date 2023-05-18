namespace SafariParkTests
{
    public class PersonTests
    {


        [TestCase("Cathy", "French", "Cathy French")]
        [TestCase("", "", " ")]
        public void GetFullNameTest(string fName, string lName, string exp)
        {
            var subject = new Person(fName, lName);
            var result = subject.FullName;
            Assert.That(result, Is.EqualTo(exp));
        }
        [Test]
        public void AgeTest()
        {
            var subject = new Person("A", "B");
            subject.Age = 30;
            Assert.That(subject.Age, Is.EqualTo(30));
        }
        [Test]
        public void GivenInvalidAge_Age_RetrunsArgumentException()
        {
            var subject = new Person("A", "B");
            Assert.Throws<ArgumentException>(() => subject.Age = -5);
            Assert.Throws<ArgumentException>(() => subject.Age = 155);
        }
        [Test]
        public void GivenNoAttributes_DefaultPersonConstructor_CreateClass()
        {
            var subject = new Person();
            Assert.That(subject, Is.TypeOf<Person>());
            Assert.That(subject.FirstName, Is.Empty);
            Assert.That(subject.LastName, Is.Empty);
            Assert.That(subject.Age, Is.Zero);
        }


    }

    public class StructTests
    {

    }
}