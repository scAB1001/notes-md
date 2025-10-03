---
title: Connect Your Obsidian Vault with Github
---
Sync your notes from Obsidian to GitHub for free! [[https://youtu.be/5YZz38U20ws|YouTube tutorial]]

1. Create a repository or [[publish-your-obsidian-notes-with-linked-blog-starter|fork the md repo]] in GitHub
2. [Download Git](https://git-scm.com/downloads)
3. Create a [personal access token](https://docs.github.com/en/authentication/keeping-your-account-and-data-secure/creating-a-personal-access-token#creating-a-personal-access-token-classic) from GitHub
4. Install the [Obsidian Git](https://github.com/denolehov/obsidian-git/wiki/Installation) community plugin
5. Create a folder to store the repo. (e.g. `remote-blog/`). Set scopes to repo & expiration to never
6. Run the command (`Ctrl + P`):  `Clone an existing remote repo`
7. Paste the URL of the forked repository in the SSH format:
```bash
git@github.com:scAB1001/notes-md.git
```
7. Then type in the folder you created in step 5 (e.g. `remote-blog/`)
8. Restart Obsidian
9. Make edits to your notes
10. Publish your notes with git commit and push by opening the command palette (`Ctrl + P`)