"use strict";

var username;
const users = [
  {
    username: "eyup",
    password: "deneme123",
    notes: [
      {
        id: 0,
        noteCreator: "eyup",
        noteTitle: "Toplantı Sonuçları",
        noteContent:
          "Lorem ipsum dolor sit amet consectetur adipisicing elit. Accusamus expedita deserunt autem quaerat, magni veritatis nostrum placeat! Nemo voluptas sed voluptatum minus quasi ratione optio nostrum debitis fugiat alias ducimus modi porro, praesentium totam accusamus quo suscipit esse impedit quia dolores autem? Quas fugit officia ratione dolore dolorem ea voluptate?",
        addedUsers: ["eyup2"],
      },
      {
        id: 1,
        noteCreator: "eyup2",
        noteTitle: "Ortak Noktalar",
        noteContent:
          "Lorem ipsum dolor sit amet consectetur adipisicing elit. Itaque, amet odio iste error delectus aspernatur ut omnis at molestias, fugit quis. Laudantium qui aut fuga!",
        addedUsers: ["eyup"],
      },
    ],
  },
  {
    username: "eyup2",
    password: "deneme1234",
    notes: [
      {
        id: 1,
        noteCreator: "eyup2",
        noteTitle: "Toplantı Sonuçları",
        noteContent:
          "Lorem ipsum dolor sit amet consectetur adipisicing elit. Accusamus expedita deserunt autem quaerat, magni veritatis nostrum placeat! Nemo voluptas sed voluptatum minus quasi ratione optio nostrum debitis fugiat alias ducimus modi porro, praesentium totam accusamus quo suscipit esse impedit quia dolores autem? Quas fugit officia ratione dolore dolorem ea voluptate?",
        addedUsers: ["eyup"],
      },
      {
        id: 0,
        noteCreator: "eyup",
        noteTitle: "Ortak Noktalar",
        noteContent:
          "Lorem ipsum dolor sit amet consectetur adipisicing elit. Itaque, amet odio iste error delectus aspernatur ut omnis at molestias, fugit quis. Laudantium qui aut fuga!",
        addedUsers: ["eyup2"],
      },
    ],
  },
  {
    username: "eyup3",
    password: "deneme1234",
    notes: [],
  },
];

var noteIndexCounter = 2;

function tryLogin() {
  checkEmptyFields();
  var userFound = false;
  for (let i = 0; i < users.length; i++) {
    const user = users[i];

    if (
      user.username === usernameInput.value &&
      user.password == passwordInput.value
    ) {
      document.querySelector(".header").children[1].classList.toggle("hidden");
      document.querySelector(".header").children[2].classList.toggle("hidden");
      document.querySelector(".showroom").classList.toggle("hidden");
      document.querySelector(".mainContent").classList.toggle("hidden");
      document.querySelector(".welcome").textContent =
        "Welcome, " + usernameInput.value;
      userFound = true;
      username = usernameInput.value;
      return;
    }
  }
  if (!userFound) alert("Wrong credentials!");
}

function checkEmptyFields() {
  if (usernameInput.value.length == 0 || passwordInput.value.length == 0) {
    alert("Username and Password cannot be empty!");
  }
}
function onFocusOutField(element) {
  if (element.value.length == 0) element.style.outline = "2px solid red";
  else element.style.outline = "none";
}
document.querySelector("#loginButton").addEventListener("click", tryLogin);

const usernameInput = document.querySelector("#usernameField");
usernameInput.addEventListener("focusout", () =>
  onFocusOutField(usernameInput)
);
const passwordInput = document.querySelector("#passwordField");
passwordInput.addEventListener("focusout", () =>
  onFocusOutField(passwordInput)
);

//-----------------------
document.querySelector(".header").children[1].classList.toggle("hidden");
document.querySelector(".header").children[2].classList.toggle("hidden");
document.querySelector(".showroom").classList.toggle("hidden");
document.querySelector(".mainContent").classList.toggle("hidden");
document.querySelector(".welcome").textContent =
  "Welcome, " + usernameInput.value;
username = "eyup";
//-----------------------

var selectedNote;

function getNotes() {
  var notes;
  for (let i = 0; i < users.length; i++)
    if (username == users[i].username) {
      notes = users[i].notes;
      break;
    }

  const noteHolder = document.querySelector("#mainNotes");
  for (let i = 0; i < notes.length; i++) {
    const noteInformation = notes[i];
    const newNote = document.createElement("button");
    newNote.classList.add("note");

    newNote.innerHTML = `
            <div class="noteInfo">
                <p class="noteID">${noteInformation.id}</p>
                <p class="noteTitle"><b>${noteInformation.noteTitle}</b></p>
                <p class="noteCreator">Creator: ${noteInformation.noteCreator}</p>
            </div>`;
    newNote.addEventListener("click", () => selectNote(noteInformation.id));
    noteHolder.appendChild(newNote);
  }
}

getNotes();

function selectNote(id) {
  for (let i = 0; i < users.length; i++)
    if (username == users[i].username)
      for (let j = 0; j < users[i].notes.length; j++)
        if (id == users[i].notes[j].id) selectedNote = users[i].notes[j];

  document.querySelector("#noteContent").textContent = selectedNote.noteContent;
  document.querySelector("#noteTitle").value = selectedNote.noteTitle;
}

const foundUserCombobox = document.querySelector("#foundUsers");
for (let i = 0; i < users.length; i++) addNewUser(users[i]);

function addNewUser(user) {
  const u = document.createElement("option");
  u.value = user.username;
  u.text = u.value;
  foundUserCombobox.appendChild(u);
}

function searchUser() {
  const usernameSearchField = document.querySelector(
    "#usernameSearchField"
  ).value;
  if (usernameSearchField.length < 3)
    alert("Please enter at least 3 characters!");

  for (let i = foundUserCombobox.children.length - 1; i >= 1; i--)
    foundUserCombobox.removeChild(foundUserCombobox.children[i]);

  for (let i = 0; i < users.length; i++) {
    const u = users[i];
    if (u.username.includes(usernameSearchField, 0)) {
      addNewUser(u);
    }
  }
}
document
  .querySelector("#searchUserButton")
  .addEventListener("click", searchUser);

function createText() {
  document.querySelector("#noteTitle").value = "Untitled";
  document.querySelector("#noteContent").value = "";

  const noteHolder = document.querySelector("#mainNotes");
  const newNote = document.createElement("button");
  newNote.classList.add("note");
  const newID = noteIndexCounter;
  noteIndexCounter++;
  newNote.innerHTML = `
            <div class="noteInfo">
                <p class="noteID">${newID}</p>
                <p class="noteTitle"><b>${"Untitled"}</b></p>
                <p class="noteCreator">Creator: ${username}</p>
            </div>`;

  newNote.addEventListener("click", () => selectNote(newID));
  noteHolder.appendChild(newNote);
}
document.querySelector("#createText").addEventListener("click", createText);
function addUser() {
  const uName = foundUserCombobox.value;

  if (uName == "0") {
    alert("You have to select a user!");
    return;
  } else if (uName == username) {
    alert("You can't choose yourself!");
    return;
  } else if (!selectedNote) {
    alert("You have to choose a note!");
    return;
  }

  users.forEach((u) => {
    if (u.username != uName) return;

    var noteExist = false;
    u.notes.forEach((n) => {
      if (n.id == selectedNote.id) {
        noteExist = true;
        return;
      }
    });
    if (noteExist) {
      alert("This user already has this note!");
      return;
    }
    u.notes.push(selectedNote);
    u.notes.forEach((newNotes) => {
      console.log(newNotes.id);
    });
    alert("Note added to user!");
  });
}
document.querySelector("#addUser").addEventListener("click", addUser);

function removeUser() {
  const uName = foundUserCombobox.value;

  if (uName == "0") {
    alert("You have to select a user!");
    return;
  } else if (uName == username) {
    alert("You can't choose yourself!");
    return;
  } else if (!selectedNote) {
    alert("You have to choose a note!");
    return;
  } else if (selectedNote.noteCreator != username) {
    alert("You can't add or remove user if you are not the creator!");
    return;
  }

  users.forEach((u) => {
    if (u.username != uName) return;

    for (let i = 0; i < u.notes.length; i++) {
      const n = u.notes[i];
      if (n.id == selectedNote.id) {
        u.notes.splice(i, 1);
        alert("Note removed from the user!");
        return;
      }
    }
    u.notes.forEach((n) => {
      console.log(n.noteTitle);
    });
  });
  alert("This user is not ");
}

document.querySelector("#removeUser").addEventListener("click", removeUser);
