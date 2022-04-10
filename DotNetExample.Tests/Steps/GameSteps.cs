using TechTalk.SpecFlow;
using System;
using NUnit.Framework;
using FluentAssertions;
using levelup;

namespace DotNetExample.Tests.Steps
{
    [Binding]
    public class GameSteps
    {
        // private readonly ScenarioContext _scenarioContext;
        private GameController testObj = new GameController();

        private String playerName = "";

        public GameSteps(ScenarioContext scenarioContext)
        {
            //   _scenarioContext = scenarioContext;
        }

        [Given(@"the player's name is ""(.*)""")]
        public void GivenThePlayersNameIs(string playerNameInput)
        {
            this.playerName = playerNameInput;
        }

        [When(@"the player sets their name")]
        public void whenThePlayerSetsTheirName()
        {
            testObj = new GameController();
            testObj.createCharacter(playerName);
        }
        [Then(@"the Game sets the player's name to ""(.*)""")]
        public void ThenTheResultShouldBe(string playerNameOutput)
        {
            testObj.getStatus().playerName.Should().Be(playerNameOutput);
        }
    }
}