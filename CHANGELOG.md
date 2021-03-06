# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

## [2.1.0] - 2020-04-30
### Added
- New item Reminder added.
- New option for quick rendering in the settings.
- Added ability to create custom folders.
- Search added.
- New icons added.

### Changed
- Updated user interface.
- Base storage method changed.
- Animations on the start page are simplified.
- Now, when changing the theme, the resource with icons is reloaded.
- The name of the database now does not contain an extension.
- Minor changes in the logical component.

### Fixed
- Partially fixed display of text (blur).
- If you lock the store, and then create a new one, the unlock button will become active.

## [2.0.0] - 2020-03-04
### Added
- Added buttons for moving items.
- Added icons for items in the list.
- Now the name of the storage is displayed in the program itself.
- Cancel button added in some windows

### Changed
- Completely rewritten application.
- Start page changed.
- Changed the program logo and name.
- Encryption logic changed.
- Montserrat font removed.
- The change in the item is displayed in real time.
- Changed links in About window.
- Changed interface in Password Generator.

### Fixed
- Fixed autorun program.
- The color of the pointer in the text input field is fixed, now it depends on the theme (dark and white).

## [1.3.0.295] - 2020-02-15
### Added
- Added notification of changes, item additions, and storage creation.
- Added save indicator.
- Added "Copy" button in password generator.
- Added button to go to Facebook in About.
- Autostart option added.
- Added warning text in settings.
- Added the name of the file storage in the program header.

### Changed
- Information in the About window is centered.
- Two separate components for viewing passwords is now one.
- Autosave is now activated every 2 minutes.

### Fixed
- Fixed a bug where the program ends sometimes after copying some text.
- Critical bug fixed, If you open one more with open storage, do not unlock it and save it, then when you open the latter, what is opened earlier is displayed.
- Fixed a bug where, after changing the login or bank card, the changes were not displayed

## [1.2.0.235] - 2020-02-05
### Added
- Dark theme added.
- Added taskbar icon.
- Added the ability to encrypt passports.
- Added autosave storage in three minutes.
- Added a theme selection to the settings window.
- Added the ability to lock and unlock storage.
- Added a small window when you click on the icon in the taskbar, allowing you to view passwords and nothing more.

### Changed
- Changed the appearance of the settings window.
- The appearance of the program is slightly changed.
- The storage encryption logic has been slightly changed.
- The localization is slightly changed.
- Now you will not be able to add a login until you create or unlock a storage.
- The background color of the windows is changed.

### Fixed
- Fixed a bug when selecting an item from the list, instead of a login, data for a bank card was displayed.

## [1.1.0.145] - 2020-01-18
### Added
- Additional hotkeys added.
- Added item type change.
- Added notification function about new updates.
- 5 new languages added: English, Armenian, French, Ukrainian and German.
- Added saving of "Bank card" element.
- Added language selection to the settings item.

### Changed
- Changed the start background of the program.
- Difficulty indicator colors changed.
- About window changed.

### Fixed
- Fixed termination of the program when there are no connected storages yet.

## [1.0.0.90] - 2020-01-10
- First release.
