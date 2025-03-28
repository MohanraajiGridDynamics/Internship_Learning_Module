1. git init
   Explanation: Initializes a new Git repository. This is the first command to run when you want to start tracking a project with Git.

Usage:


````
git init
````
Example:
This will create a .git directory, initializing the current directory as a Git repository.

````
mkdir my-project
cd my-project
git init
````

2. git add
   Explanation: Adds changes in your working directory to the staging area, which is the first step before committing those changes. You can add individual files or all modified files.

Usage:

bash
Copy code
````
git add <file>  # Add a specific file
git add .       # Add all changes in the directory
````

Example:

bash
Copy code
````
git add index.html
git add .   # Add all changes in the directory
````

3. git commit
   Explanation: Saves the staged changes to your local repository with a descriptive message.

Usage:

bash
Copy code
````
git commit -m "Your commit message"
````
Example:

bash
Copy code
````
git commit -m "Fixed the homepage layout"
````

4. git status
   Explanation: Shows the status of your working directory and staging area. It will tell you which files are staged, modified, or untracked.

Usage:

bash
Copy code
````
git status
````

Example:

bash
Copy code
````
git status
````
This will display something like:

vbnet
Copy code
````
On branch main
Your branch is up to date with 'origin/main'.

Changes to be committed:
(use "git restore --staged <file>..." to unstage)
modified:   index.html
````

5. git log
   Explanation: Shows the commit history of the repository, including commit hashes, author names, dates, and commit messages.

Usage:

bash
Copy code
````
git log
````
Example:

bash
Copy code
````
git log
````
This will output something like:

sql
Copy code
````
commit 4a5f6d9bc710f6e0c13d4b8b8a9377124bb1200d (HEAD -> main)
Author: Your Name <your.email@example.com>
Date:   Thu Mar 25 12:34:56 2025 -0400

    Fixed homepage layout issue

commit 2b4c2fbd3ed83e4f9f321c4593f7a9f713fba937
Author: Your Name <your.email@example.com>
Date:   Wed Mar 24 16:22:48 2025 -0400

    Initial commit
````

6. git clone
   Explanation: Copies a remote repository to your local machine. It includes all history and branches from the remote repository.

Usage:

bash
Copy code
````
git clone <repository-url>
````

Example:

bash
Copy code
````
git clone https://github.com/user/repository.git
````

7. git branch
   Explanation: Lists all branches in the repository. It can also be used to create new branches.

Usage:

bash
Copy code
````
git branch         # List all branches
git branch <branch-name>  # Create a new branch
````

Example:

bash
Copy code
````
git branch          # List branches
git branch feature  # Create a new branch named "feature"
````

8. git checkout
   Explanation: Used to switch between branches or restore files. You can use it to move to a different branch or revert changes in your working directory.

Usage:

bash
Copy code
````
git checkout <branch-name>  # Switch to a different branch
git checkout -- <file>      # Discard changes in a file
````
Example:

bash
Copy code
````
git checkout feature  # Switch to the "feature" branch
git checkout -- index.html  # Discard changes in index.html
````
9. git merge
   Explanation: Merges changes from one branch into another. It's typically used to combine a feature branch back into the main branch.

Usage:

bash
Copy code
````
git merge <branch-name>
````
Example:

bash
Copy code
````
git checkout main      # Switch to the main branch
git merge feature      # Merge the "feature" branch into main
````
10. git remote
    Explanation: Manages remote repositories. You can add, view, or remove remote repositories.

Usage:

bash
Copy code
````
git remote add <name> <url>    # Add a remote repository
git remote -v                  # View remotes
````
Example:

bash
Copy code
````
git remote add origin https://github.com/user/repository.git
git remote -v
````
11. git push
    Explanation: Pushes local commits to a remote repository. You'll need to specify which branch you are pushing to.

Usage:

bash
Copy code
````
git push <remote> <branch>
````
Example:

bash
Copy code
````
git push origin main
````
12. git pull
    Explanation: Fetches and integrates changes from a remote repository into your local branch.

Usage:

bash
Copy code
````
git pull <remote> <branch>
````
Example:

bash
Copy code
````
git pull origin main
````

13. git diff
    Explanation: Shows the differences between the working directory and the staging area or between two commits.

Usage:

bash
Copy code
````
git diff             # Show changes between working directory and staging area
git diff <commit1> <commit2>  # Compare two commits
````

Example:

bash
Copy code
````
git diff
````

These are some of the basic and frequently used Git commands to help you get started with version control and repository management! Let me know if you want more detailed examples or explanations for any of them.