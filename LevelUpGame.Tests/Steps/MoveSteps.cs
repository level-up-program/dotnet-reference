using System;
using System.Drawing;
using FluentAssertions;
using levelup;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace DotNetExample.Tests.Steps
{
    [Binding]
    public class MoveSteps
    {
        GameController testObj = new GameController();
        int startX, startY;
        GameController.DIRECTION direction;
        Point currentPosition;

        [Given(@"the character starts at position with XCoordinates {int}")]
        public void givenTheCharacterStartsAtX(int startX)
        {
            this.startX = startX;
        }

        [Given(@"starts at YCoordinates {int}")]
        public void givenTheCharacterStartsAtY(int startY)
        {
            this.startY = startY;
        }

        [Given(@"the player chooses to move in {word}")]
        public void givenPlayerChoosesDirection(String direction) {
            this.direction = (GameController.DIRECTION) Enum.Parse(typeof(GameController.DIRECTION) , direction);
        }

        [When(@"the character moves")]
        public void whenTheCharacterMoves()
        {
            testObj.SetCharacterPosition(new Point(this.startX, this.startY));
            testObj.Move(this.direction);
            GameController.GameStatus status = testObj.GetStatus();
            this.currentPosition = status.currentPosition;
        }

        [Then(@"the character is now at position with XCoordinates {int}")]
        public void checkXCoordinates(int endX)
        {
            Assert.NotNull(this.currentPosition, "Expected position not null" );
            Assert.Equals(endX, this.currentPosition.X);
        }

        [Then(@"YCoordinates {int}")]
        public void checkYCoordinates(int endY)
        {
            Assert.NotNull(this.currentPosition, "Expected position not null");
            Assert.Equals(endY, this.currentPosition.Y);
        }
    }
}