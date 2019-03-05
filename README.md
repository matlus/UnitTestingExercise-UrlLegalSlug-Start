# Unit Testing Exercise - UrlLegalSlug - Start

## Introduction
This repository is the starting point of the UrlLegalSlug Unit Testing Exercise. In this exercise you will write unit tests for the `SlugProducer` class. This class is made available to you via a compiled assembly (so that you don’t write tests based on the implementation). Below are the requirements this class satisfies. That is, the class has been developed based on these requirements and it satisfies **all** of the stated requirements.

## Requirements for a Slug Producer
Given a string (Typically a title of a blog post, video post etc.) this class will produce a URL legal string by replacing illegal characters with a blank. There are some *"Allowed"* illegal characters that are replaced with a __*dash*__ (minus sign) and they are:

#### *"Allowed"* illegal characters
1. Space
2. Period
3. Dash (minus sign)
4. Long dash (unicode \u2013)

If there are multiple contiguous __*"Allowed"*__ illegal characters in the given string then all of them will be replaced by a **single** dash.
If the resulting string starts with or ends with a dash then those dashes will be removed. Thus, the returned string will never start with or end with a dash. Further, all alpha characters will be converted to lower case.

#### Legal URL characters are:
1. A through Z
2. a through z
3. 0 through 9
4. Minus sign (-)

### Examples
| Original string | Resulting Url Legal Slug |
| --- | --- |
| `Requirements for a Slug Producer` | `requirements-for-a-slug-producer` |
| `jQuery.data()–Assigning objects to dynamic elements` | `jquery-data-assigning-objects-to-dynamic-elements` |
| `$@!What[are you talking about? !!` | `whatare-you-talking-about` |

## Your Mission if you choose to accept it
Given the above information you are required to determine the various *test scenarios* and their *expectations* for which you need to write unit tests for.

Since you don’t have the source code for the __*SlugProducer*__ class, you can’t see the Code Coverage you’re getting until you move on to the next step. The basic idea is that given a set of requirements that a class or system has been developed to satisfy, you should be able to write tests for various scenarios and expectations (that **you** need to analyze and extract) and when you’re done, you should get 100% code coverage. **Note** that a code coverage of 100% does **Not** mean that you've written all of the required unit tests (the scenarios and their expectations).

#### Note
Writing too many tests is **not** the way to approach this. You need to think about exactly what scenarios you should be testing (given the requirements).
So essentially, you're writing the minimum number of tests that:
1. Exercise all the stated requirements and thus ensure the class does what is expected of it
2. If anything in the class' implementation changes such that a requirement is not being met, one or more tests should fail
3. You get 100% code coverage
4. Refactoring the implementation of the class (if done correctly) should still give you 100% code coverage (assuming no tests are failing)

## What is in this Repository
1. A Visual Studio .Net framework Unit Test project (`UrlLegalSlugTests.csproj`)
2. The Compiled assembly (`UrlLegalSlug.dll`) that contains the SlugProducer class
3. A Test Class (`SlugProducerTests`) that has one test method implemented

The test project already references the assembly and there is already one test scenario implemented. You need to figure out what other scenarios need to be tested by looking at, understanding and analyzing the requirements.

```C#
[TestMethod]
[TestCategory("ClassTest")]
public void SlugProducer_GetUrlSlug_WhenTitleContainsNoIllegalCharacters_ReturnsAsIs()
{
    // Arrange
    var expectedSlug = "abcdegfhijklmnopqrstuvwxyz0123456789";

    // Act
    var actualSlug = SlugProducer.GetUrlSlug(expectedSlug);

    // Assert
    Assert.AreEqual(expectedSlug, actualSlug, $"We were expecting the Url slug to be: {expectedSlug}, but found the actual Url slug to be {actualSlug}");
}
```
The method name above has the following parts seperated by the underscore character

| Method Name Part | Purpose/Meaning |
| --- | --- |
| `SlugProducer` | `The name of the class being tested` |
| `GetUrlSlug` | `The name of the method being tested` |
| `WhenTitleContainsNoIllegalCharacters` | `The Scenario being tested` |
| `ReturnsAsIs` | `The expectation` |

### YouTube Video - Unit Testing Re-Booted
[![Unit Testing Rebooted](http://img.youtube.com/vi/OBoq3zkL8r0/0.jpg)](https://youtu.be/OBoq3zkL8r0)

### Watch the Entire Unit Testing Re-Booted Playlist
[![Unit Testing Re-Booted Playlist](http://img.youtube.com/vi/OBoq3zkL8r0/0.jpg)](https://www.youtube.com/watch?v=OBoq3zkL8r0&list=PLJ0hAqAAdnpCg1ZzaQIgh7VZAWC-C8qrx)
