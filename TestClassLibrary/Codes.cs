using System.Security.Policy;

namespace GitCodes
{
    public class Codes
    {

                // Below are the basic and all necessary codes of git
                
                  Creat Repository in GitHub:
                  1. cd /e/Sabir/test/GitPracticesSolution/
                  2. git init
                  3. git add.
                  4. git commit -m "Initial commit"
                  5. git remote add origin <repository-url> 
                  6. git push -u origin master
        
         Create Branch
                  1. cd /e/Sabir/test/GitPracticesSolution/
                  2. git branch
                  3. git checkout -b SabirBranch1
                  4. git add .
                  5. git commit -m "Your commit message here"
                  6. git push origin SabirBranch1
                  7. git checkout main
        
         Delete Last Commit
                  1. git log
                  2. git revert <commit_hash>       // 0008bea285081c37dee0043418ds44346ssc00
                  3. git push origin SabirBranch1
                  7. git checkout main
        
         Merge Branch
                  1. git checkout master
                  2. git pull origin master
                  3. git merge SabirBranch1
                  4. git push origin master
         
                  // use these codes to work with git professionally



    }
}
