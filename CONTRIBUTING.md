# Contributing Guidelines

Thank you for contributing to this project! Please follow these conventions to maintain consistency.

## Branch Naming Conventions

Branch names should be descriptive and follow this format:

```
<type>/<username>/<short-description>
```

### Types

- `feature/` - New features or functionality
- `fix/` - Bug fixes
- `docs/` - Documentation changes
- `refactor/` - Code refactoring without changing functionality
- `test/` - Adding or updating tests
- `chore/` - Maintenance tasks, dependency updates, etc.

### Examples

```
feature/larryling/player-inventory-system
fix/larryling/jump-animation-glitch
docs/larryling/update-level-design-guide
refactor/larryling/optimize-particle-effects
test/larryling/add-collision-tests
chore/larryling/update-unity-version
```

## Commit Message Conventions

Follow the Conventional Commits format:

```
<type>: <short summary>

[optional body]

[optional footer]
```

### Types

- `feat:` - New feature
- `fix:` - Bug fix
- `docs:` - Documentation changes
- `style:` - Code style/formatting (no functional changes)
- `refactor:` - Code refactoring
- `test:` - Adding or updating tests
- `chore:` - Maintenance tasks
- `hotfix:` - Emergency fixes

### Guidelines

- Use the imperative mood ("add" not "added" or "adds")
- Keep the summary line under 72 characters
- Capitalize the first letter of the summary
- Do not end the summary with a period
- Separate subject from body with a blank line
- Use the body to explain what and why, not how

### Examples

```
feat: add double jump mechanic

fix: resolve enemy AI pathfinding bug in level 3

docs: update shader documentation for water effects

refactor: optimize rendering pipeline for mobile

test: add unit tests for weapon damage calculations

chore: upgrade Unreal Engine to 5.4

hotfix: fix gamebreaking bug
```

## Pull Request Process

1. Create a feature branch from `main`
2. Make your changes with clear, descriptive commits
3. Update documentation as needed
4. Submit a pull request with a clear description of changes
5. Request review from maintainers

Thank you for your contributions!
