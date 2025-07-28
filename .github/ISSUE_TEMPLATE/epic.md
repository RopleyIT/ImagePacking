---
name: Epic
about: A strategic area of work delivering in a specific area of business value.
title: Epic title goes here
labels: ''
assignees: ''
body:
  - type: dropdown
    id: state
    attributes:
      label: State
      description: Current workflow state
      options:
        - New
        - In progress
        - Closed
        - Removed
      default: 0
    validations:
      required: true
  - type: input
    id: iteration
    attributes:
      label: Iteration
      description: Which release/sprint/iteration?
      placeholder: On backlog
    validations:
      required: false
  - type: textarea
    id: description
    attributes:
      label: Description
      description: Description of area covered by epic
      placeholder: Add a description of the epic here...
    validations:
      required: true
  - type: input
    id: business-value
    attributes:
      label: Business value
      description: Business value estimate for managing relative priority of epics
      placeholder: Add a business value estimate here (optional)...
    validations:
      required: false
---


