# IDE Laboratory Work #1

## Subject

Command Line Interface; CLI Editors; Setting Server Environment; Version Control Systems

## Objectives:
  - Understanding and using CLI (basic level)
  - Administration of a remote linux machine using SSH
  - Ability to work remotely (remote code editing)
  - Ability to work with VCS

## Executed Tasks:
  - **Mandatory Tasks:**
    - Connect to a remote server via SSH
    - Initialize a repository on server
    - Create a file in repository folder, write in your name, save it and commit it
  - **Tasks With Points:**
    - Connect to server using public key (1 pt)
    - Create 2 more branches with at least one unique committed file per branch (1 pt)
    - Set a branch to track a remote origin on which you are able to push (ex. github, bitbucket or a custom server) (1 pt)
    - Reset a branch to previous commit, reset a branch to some specific commit (1 pt)
    - Restore a reset branch back to its previous state (1 pt)
    - Create a VCS alias (1 pt)
    - GIT cherry-pick, rebase (1 pt)
    - Create a VCS hook (1 pt)
    - Master any CLI editor (ex. VIM). Learn 10 commands' sets (a/A/i/I/o/O is one set) to prove your mastery (1 pt)
    - Create your own server (ex. virtual machine) (2 pt)
    - Create a VCS merge conflict and solve it (1 pt)
  

## Theoretical Work:
I used VCS only in two projects,but I used it in order to push the info on the repository but I never used branches or something else.That's why this laboratory work was very interesting for me because I learned the basics of branches and other stuff like alias and hook.
Also it was interesting because it was the first time when I connected by an SSH connection and worked remote with git.It was awesome.Also I found new things in terminal,because I never worked with terminal so much as in this laboratory work.
I found the vim and the basics terminal commands like:ls,mkdir,cat,cp,rm and cd.Also I learned some new commands in vim.

##Practical Work
I started by coneccting to a remote server via SSH, i done it when I was at laboratory work.For windows I utilizied a tool named Putty and there you just specify the host and the username,password for connecting.
In order to connect from Ubuntu, I used the command: ssh remote_username@remote_host and after that it asks you the password.That's how I made a connection with a remote PC via SSH.
Next step was to intialize a remote server.For this purpose I used VCS git.In order to make a repository to a specific project you first have to go to that directory by using command from terminal : cd _pathToDirectory 
The command for initializing a local repository by git: git init. Then it automatically creates a hiden folder .git
where are stored all data about respotiry
The third task was to create a file in repository,I used command: touch _filename , then I written my name by using command: echo "Iura Gaitur">filename or by using vim _filename, writing "Iura Gaitur" and then in order to write just pressing Esc and :wq, w-write and q-quit from file.
In order to commit changes I had to write git add . then git commit -m"First commit"

After that i went to branches.I never used before branches but I understood their main usability by reading some articles about them.In git it's very easy to work with branches. In order to create a new branch you just write:
git branch _nameBranch.If you want to change from one branch to another you just write:git checkout _nameBranch, and if you want to see all local branches then you just type git branch, and it will list you all local branches.

More I was using git more I liked it.

Then I set to track a remote origin on which I will be able to push. At the beginning I used my own repository,
after that I connected to the one for laboratories needs.
In order to connect local repository to a remote one, I used the command: git add origin master _linkToRepository.
This set a link to remote repository by using origin key. 
In order to push from the tracked repository we use the command:git push origin _branch
If we will use Http then git will ask us the username and password from git,if SSH then we will have to make a SSH connection by generating a key and copy and setting it on our settings profile. 

Next task was to reset a branch to the previous state or to a specific state:
There a re 2 posibility to go to different commits: by reseting them or just by going to them by using git checkout _nameCommit.
But for this we need their names or id.We can find them by using command: git log, that will show all commits descending
So command for reset is:git reset --hard HEAD~1.This will  reset to previous commit, in order to reset to some specific commit then the command is: git reset _nameCommit.

In order to restore a branch to a previous commit just type command:git reset HEAD@{1}

The next stuff was alias.It's a very useful, especially when you use vcs systems very often.
It helps you to change a git command with a specified command for example:git checkout with git co.
For this we change config file by typing command:
git config --global alias.co checkout
git config --global alias.ci commit
git config --global alias.st status
git config --global alias.br branch

I creating a git conflict when I tried to merge a branch with a file Readme deleted but not in the master branch.I could see the conflict description by typing git status.I resolved this conflict by deleting the file from my master branch too by using rm Readme.md and then just git add --all and commit -m"Resolved conflict".


Some of them are used for working with files another for working with text. :q-quit,w-write,r-read,!-not save the changes,w-next word,b-,[-to the next sentence,]-to the previous sentence,{-to the privious paragraph, }-to the next paragraph.
