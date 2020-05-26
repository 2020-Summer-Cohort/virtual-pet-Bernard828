using System;
using Xunit;

namespace VirtualPet.Tests
{
    public class PetTests
    {
        private Pet testPet;

        public PetTests()
        {
           Pet testPet = new Pet();
        }

        [Fact]
        public void Pet_Constructor_Should_Instantiate_Pet_Object()
        {
            Assert.NotNull(testPet);
        }

        //INSTRUCTIONS:
        // Uncomment code in the test body one test at a time
        // Add source code to eliminate the build errors(red squiggle) and pass the test

       [Fact]
        public void Pet_Should_Have_Name()
        {
            testPet.Name = "Fluffy";

            Assert.NotNull(testPet.Name);
        }

        [Fact]
        public void SetName_Should_Assign_Pet_Name_Property()
        {
            testPet.SetName("Fluffy");

            Assert.Equal("Fluffy", testPet.Name);
        }

        [Fact]
        public void GetName_Should_Get_Pet_Name_Value()
        {
            testPet.GetName();                               //testPet.GetName("Fido");

            string testPetName = testPet.GetName();         //string testPetName = testPEt.GetName("Fido");

            Assert.Equal("Fido", testPetName);              //Assert.Equal("Fido", testPetName);
        }

        [Fact]
        public void Pet_Should_Have_Species()
        {
            Assert.NotNull(testPet.Species);
        }

        [Fact]
        public void SetSpecies_Should_Assign_Pet_Species_Property()
        {
            testPet.SetSpecies("Cat");

            Assert.Equal("Cat", testPet.Species);
        }

        [Fact]
        public void GetSpecies_Should_Get_Pet_Species_Value()
        {
            testPet.SetSpecies("Dog");

            string testPetSpecies = testPet.GetSpecies("Dog");

            Assert.Equal("Dog", testPetSpecies);
        }

        [Fact]
        public void Pet_Should_Have_Hunger()
        {
            Assert.NotNull(testPet.Hunger);
        }

        [Fact]
        public void GetHunger_Should_Return_Initial_Hunger_Level_Of_50()
        {

            int testPetHunger = testPet.GetHunger();

            Assert.Equal(50, testPetHunger);
        }

        [Fact]
        public void Pet_Should_Have_Thirst()
        {
            Assert.NotNull(testPet.Thirst);
        }

        [Fact]
        public void GetThirst_Should_Return_Initial_Thirst_Level_Of_50()
        {
            int testPetThirst = testPet.GetThirst();

            Assert.Equal(50, testPetThirst);
        }

        [Fact]
        public void Pet_Should_Have_Health()
        {
            Assert.NotNull(testPet.Health);
        }

        [Fact]
        public void GetHealth_Should_Return_Initial_Health_Level_Of_50()
        {
            int testPetHealth = testPet.GetHealth();

            Assert.Equal(50, testPetHealth);
        }

        [Fact]
        public void Feed_Should_Decrease_Hunger_By_5()
        {
            testPet.GetHunger();

            testPet.Feed();

            Assert.Equal(45, testPet.GetHunger());
        }

        [Fact]
        public void SeeDoctor_Should_Increase_Health_By_30()
        {
            testPet.GetHealth();

            testPet.SeeDoctor();

            Assert.Equal(80, testPet.GetHealth());
        }

        [Fact]
        public void Play_Should_Increase_Hunger_By_10()
        {
            testPet.GetHunger();

            testPet.Play();

            Assert.Equal(60, testPet.GetHunger());
        }

        [Fact]
        public void Play_Should_Increase_Thirst_By_20()
        {
            testPet.GetThirst();

            testPet.Play();

            Assert.Equal(70, testPet.GetThirst());
        }

        [Fact]
        public void Play_Should_Increase_Health_By_10()
        {
            testPet.GetHealth();

            testPet.Play();

            Assert.Equal(60, testPet.GetHealth());
        }

        [Fact]
        public void Tick_Should_Increase_Hunger_By_5()
        {
            testPet.GetHunger();

            testPet.Tick();

            Assert.Equal(55, testPet.GetHunger());
        }

        [Fact]
        public void Tick_Should_Increase_Thirst_By_5()
        {
            testPet.GetThirst();

            testPet.Tick();

            Assert.Equal(55, testPet.GetThirst());
        }

        [Fact]
        public void Tick_Should_Decrease_Health_By_5()
        {
            testPet.GetHealth();

            testPet.Tick();

            Assert.Equal(45, testPet.GetHealth());
        }
    }
}
