# Important #
- From the `StudentContext` if you want to, delete the `Courses` and `Enrolments`, because the `Student` already have navigational properties to those entities. So they are anyway "implicitly" referenced.
- The 'EnsureCreated' method in `DbContext` class makes sure the database is created, if the database does not exist.
