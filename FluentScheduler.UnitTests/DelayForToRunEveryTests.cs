namespace FluentScheduler.UnitTests
{
    using System;
    using Utilities;
    using Xunit;
    using static Xunit.Assert;

    public class DelayForToRunEveryTests
    {
        [Fact]
        public void Should_Delay_ToRunEvery_For_500_Milliseconds()
        {
            // Arrange
            var expected = DateTime.Now.AddMilliseconds(600);

            // Act
            JobManager.AddJob(
                () => { },
                s => s.WithName("run every 500 milliseconds and delay for 100 milliseconds")
                    .ToRunEvery(500).Milliseconds()
                    .DelayFor(100).Milliseconds()
            );
            var actual = JobManager.GetSchedule("run every 500 milliseconds and delay for 100 milliseconds").NextRun;

            // Assert
            True((expected - actual).TotalMilliseconds < 150);
        }

        [Fact]
        public void Should_Delay_ToRunEvery_For_2_Seconds()
        {
            // Arrange
            var expected = DateTime.Now.AddSeconds(12);

            // Act
            JobManager.AddJob(
                () => { },
                s => s.WithName("run every 10 seconds and delay for 2 seconds")
                    .ToRunEvery(10).Seconds()
                    .DelayFor(2).Seconds()
            );
            var actual = JobManager.GetSchedule("run every 10 seconds and delay for 2 seconds").NextRun;

            // Assert
            Equal(expected.WithoutMilliseconds(), actual.WithoutMilliseconds());
        }

        [Fact]
        public void Should_Delay_ToRunEvery_For_2_Minutes()
        {
            // Arrange
            var expected = DateTime.Now.AddSeconds(10).AddMinutes(2);

            // Act
            JobManager.AddJob(
                () => { },
                s => s.WithName("run every 10 seconds and delay for 2 minutes")
                    .ToRunEvery(10).Seconds()
                    .DelayFor(2).Minutes()
            );
            var actual = JobManager.GetSchedule("run every 10 seconds and delay for 2 minutes").NextRun;

            // Assert
            Equal(expected.WithoutMilliseconds(), actual.WithoutMilliseconds());
        }

        [Fact]
        public void Should_Delay_ToRunEvery_For_2_Hours()
        {
            // Arrange
            var expected = DateTime.Now.AddSeconds(10).AddHours(2);

            // Act
            JobManager.AddJob(
                () => { },
                s => s.WithName("run every 10 seconds and delay for 2 hours")
                    .ToRunEvery(10).Seconds()
                    .DelayFor(2).Hours()
            );
            var actual = JobManager.GetSchedule("run every 10 seconds and delay for 2 hours").NextRun;

            // Assert
            Equal(expected.WithoutMilliseconds(), actual.WithoutMilliseconds());
        }

        [Fact]
        public void Should_Delay_ToRunEvery_For_2_Days()
        {
            // Arrange
            var expected = DateTime.Now.AddSeconds(10).AddDays(2);

            // Act
            JobManager.AddJob(
                () => { },
                s => s.WithName("run every 10 seconds and delay for 2 days")
                    .ToRunEvery(10).Seconds()
                    .DelayFor(2).Days()
            );
            var actual = JobManager.GetSchedule("run every 10 seconds and delay for 2 days").NextRun;

            // Assert
            Equal(expected.WithoutMilliseconds(), actual.WithoutMilliseconds());
        }

        [Fact]
        public void Should_Delay_ToRunEvery_For_2_Weeks()
        {
            // Arrange
            var expected = DateTime.Now.AddSeconds(10).AddDays(14);

            // Act
            JobManager.AddJob(
                () => { },
                s => s.WithName("run every 10 seconds and delay for 2 weeks")
                    .ToRunEvery(10).Seconds()
                    .DelayFor(2).Weeks()
            );
            var actual = JobManager.GetSchedule("run every 10 seconds and delay for 2 weeks").NextRun;

            // Assert
            Equal(expected.WithoutMilliseconds(), actual.WithoutMilliseconds());
        }

        [Fact]
        public void Should_Delay_ToRunEvery_For_2_Months()
        {
            // Arrange
            var expected = DateTime.Now.AddSeconds(10).AddMonths(2);

            // Act
            JobManager.AddJob(
                () => { },
                s => s.WithName("run every 10 seconds and delay for 2 months")
                    .ToRunEvery(10).Seconds()
                    .DelayFor(2).Months()
            );
            var actual = JobManager.GetSchedule("run every 10 seconds and delay for 2 months").NextRun;

            // Assert
            Equal(expected.WithoutMilliseconds(), actual.WithoutMilliseconds());
        }

        [Fact]
        public void Should_Delay_ToRunEvery_For_2_Years()
        {
            // Arrange
            var expected = DateTime.Now.AddSeconds(10).AddYears(2);

            // Act
            JobManager.AddJob(
                () => { },
                s => s.WithName("run every 10 seconds and delay for 2 years")
                    .ToRunEvery(10).Seconds()
                    .DelayFor(2).Years()
            );
            var actual = JobManager.GetSchedule("run every 10 seconds and delay for 2 years").NextRun;

            // Assert
            Equal(expected.WithoutMilliseconds(), actual.WithoutMilliseconds());
        }

    }
}
