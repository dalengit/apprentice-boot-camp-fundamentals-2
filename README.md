<!--- ORGANISER THINGS TO CONSIDER 
- Which technical competencies, behaviours and knowledge module topics does the bootcamp cover/meet
- Structuring retros so that they can inform thinking for individual's personal learning records (off the job training record tab in their learning logs)
- Introducing some sort of test or quiz on basic concept learning points from the bootcamp to validate that they have taken stuff in, and provide organisation mentors with results to help them focus follow ups
--->

## Competencies, Behaviours and Knowledge units

These relate to the KSBs defined in the [Level 4 Software Developer standard](https://www.instituteforapprenticeships.org/apprenticeship-standards/software-developer-v1-1).

* **K7**: Software design approaches and patterns, to identify reusable solutions to commonly occurring problems
* **S1**: create logical and maintainable code
* **S4**: test code and analyse results to correct errors found using unit testing
* **S6**: identify and create test scenarios
* **S7**: apply structured techniques to problem solving, debug code and understand the structure of programmes in order to identify and resolve issues
* **S9**: create analysis artefacts, such as use cases and/or user stories

## Resources 

* Slides
* Laptops
* Internet access
* post-its
* pens
* flips, index cards

## Mentors / Languages
 
Two–three mentors required in addition to leads. These should be able to cover support for the required languages.

Several exercises (katas and code starters) have been ported to required languages.

## Prep-work for apprentices

* Make sure you can sign in to github.com with your own account
* **Fork** this repo (so you can push your changes later)
* Clone your fork: `git clone https://github.com/[your-username]/apprentice-boot-camp-fundamentals-2.git`
* Follow the instructions in the README for your language under the `exercises` directory, **making sure you can run the tests**
  * [Java](exercises/java/README.md)
  * [JavaScript](exercises/javascript/README.md)
  * [C#](exercises/dotnet/README.md)
* It’s normal to have problems with this, so just let us know! :)

### Follow-on tasks

Organisation mentors should look to exercise the knowledge we’ve covered in the boot camp. Below are suggestions for tasks that would do this, but please use your own judgement to work out what to do. There is no need for anything to be returned to MD or the presenters—it’s just a learning exercise.

* Take a look at one of your codebases and find examples of duplication
* Do a kata using the red green refactor practice
  * We will be doing the Bowling Kata as part of the boot camp
* Spend a day doing red green refactor on your codebase with a pair, and leave some time at the end of the day to reflect / retrospect
  * Did you enjoy it
  * What made it difficult
  * What made it easier
* Pair on a refactor where you use the IDE to refactor your code rather than manually rewriting it
* Explore ‘Refactoring Guru’ from the resources below
* Try to get better at using the keyboard shortcuts for your IDE
  * For IntelliJ, you could use the [Force Shortcuts](https://plugins.jetbrains.com/plugin/8357-force-shortcuts) plugin for a day to force you to learn, or just add popups to remind you with [Key Promoter X](https://plugins.jetbrains.com/plugin/9792-key-promoter-x)

## Further reading / learning resources

<!--- For end of boot camp: Signposting for apprentices self study, further learning, online resources, practice etc. --->

* [Refactoring Guru](https://refactoring.guru/) is a great site which covers the practices, techniques and reasons around refactoring
* [List of katas](http://codingdojo.org/kata/)
* [Michael Feathers’ Working Effectively with Legacy Code](https://www.amazon.co.uk/Working-Effectively-Legacy-Michael-Feathers/dp/0131177052) if you want a book to read
* [Uncle Bob’s Bowling Game Kata](http://www.butunclebob.com/ArticleS.UncleBob.TheBowlingGameKata) page has a Powerpoint presentation which shows step by step how he approaches solving the problem. Note his to-do list in the top left corner.
* [INVEST in Good Stories, and SMART Tasks](https://xp123.com/articles/invest-in-good-stories-and-smart-tasks/) explains some important qualities of user stories (relevant to the requirements exercise from the boot camp)
 
## Slides

The slides can be viewed from the link at the top of the repository.

## Exercises

* Receipt duplication (pairs)
* TDD Bowling Kata (pairs)
* TDDing realistic stories
* Rename refactor
* Extract variable refactor
* Extract constant refactor
* Extract method refactor
* Adapting duplicated code
* Removing duplication

# Boot Camp Summary

## TDD

* Why do we write tests
* Why do we write tests first
* Why people might not write tests first
* Arrange, Act, Assert
* Red, Green, Refactor
* Exercise: Bowling Kata with TDD
* Exercise: Implementing realistic user stories using TDD

## Refactoring

* Refactoring vs rewriting
* Exercise: Renaming things
* Exercise: Extracting variables
* Exercise: Extracting constants
* Exercise: Extracting methods

## DRY

* Definition
* Exercise: adapt poorly implemented checkout kata with lots of duplication
* How to fix
* Why duplication happens
* Exercise: refactor away duplication

# Briefing for organisation mentors

* TBC

# Working with the slides

The slides are stored as Markdown files in `docs/_posts` and are presented using a combination of Jekyll and [reveal.js](https://revealjs.com/#/). A [remote Jekyll theme](https://github.com/autotraderuk/jekyll-revealjs) is used to help make changes to the Jekyll code centrally.

The easiest way to preview your changes locally is to use docker to run Jekyll. To do this, [install docker](https://www.docker.com/get-started) if you haven’t already and run `docker-compose up` from the root of this project in a terminal. Your changes will be visible on <http://localhost:4000/>. Any changes you make to the slides will be reflected in your browser—there’s no need to restart docker. You can hit `ctrl-c` to stop the process.

Once you push your changes the slides will be published using GitHub Pages automatically (see the link at the top of the repository).
