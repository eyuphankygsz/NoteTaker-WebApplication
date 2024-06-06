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
    ]
  },
  {
    username: "eyup2",
    password: "deneme1234",
    notes: [
      {
        id: 0,
        noteCreator: "eyup2",
        noteTitle: "Toplantı Sonuçları",
        noteContent:
          "Lorem ipsum dolor sit amet consectetur adipisicing elit. Accusamus expedita deserunt autem quaerat, magni veritatis nostrum placeat! Nemo voluptas sed voluptatum minus quasi ratione optio nostrum debitis fugiat alias ducimus modi porro, praesentium totam accusamus quo suscipit esse impedit quia dolores autem? Quas fugit officia ratione dolore dolorem ea voluptate?",
        addedUsers: ["eyup"],
      },
      {
        id: 1,
        noteCreator: "eyup",
        noteTitle: "Ortak Noktalar",
        noteContent:
          "Lorem ipsum dolor sit amet consectetur adipisicing elit. Itaque, amet odio iste error delectus aspernatur ut omnis at molestias, fugit quis. Laudantium qui aut fuga!",
        addedUsers: ["eyup2"],
      },
    ]
  },
];

    function tryLogin() {

        checkEmptyFields();
        var userFound = false;
        for (let i = 0; i < users.length; i++) {
            const user = users[i];
            
            if (user.username === usernameInput.value && user.password == passwordInput.value) {
                document.querySelector(".header").children[1].classList.toggle("hidden");
                document.querySelector(".header").children[2].classList.toggle("hidden");
                document.querySelector(".showroom").classList.toggle("hidden");
                document.querySelector(".mainContent").classList.toggle("hidden");
                document.querySelector(".welcome").textContent = "Welcome, " + usernameInput.value;
                userFound = true;
                username = usernameInput.value
                return;
            }
        }
        if(!userFound)
            alert("Wrong credentials!");
    }

    function checkEmptyFields(){
        if(usernameInput.value.length == 0 || passwordInput.value.length == 0){
            alert("Username and Password cannot be empty!");
        }
    }
    function onFocusOutField(element){
        if(element.value.length == 0)
            element.style.outline = "2px solid red";
        else
            element.style.outline = "none";
    }
    document.querySelector("#loginButton").addEventListener("click", tryLogin);

    const usernameInput = document.querySelector("#usernameField");
    usernameInput.addEventListener("focusout", () => onFocusOutField(usernameInput));
    const passwordInput = document.querySelector("#passwordField");
    passwordInput.addEventListener("focusout", () => onFocusOutField(passwordInput));
    
    
    //-----------------------
    document.querySelector(".header").children[1].classList.toggle("hidden");
                document.querySelector(".header").children[2].classList.toggle("hidden");
                document.querySelector(".showroom").classList.toggle("hidden");
                document.querySelector(".mainContent").classList.toggle("hidden");
                document.querySelector(".welcome").textContent = "Welcome, " + usernameInput.value;
                username = "eyup";
    //-----------------------

    function getNotes(){
        var notes;
        for (let i = 0; i < users.length; i++) {
            if(username == users[i].username)
            {
                notes = users[i].notes;
                break;
            }
        }

        const noteHolder = document.querySelector("#mainNotes");

        for (let i = 0; i < notes.length; i++) {
            const noteInformation = notes[i];
            const newNote = document.createElement("button");
            newNote.classList.add("note");
            
            newNote.innerHTML = `
            <div class="noteInfo">
                <p class="noteTitle"><b>${noteInformation.noteTitle}</b></p>
                <p class="noteCreator">Creator: ${noteInformation.noteCreator}</p>
            </div>`;
            newNote.addEventListener("click", () => selectNote(i));
            noteHolder.appendChild(newNote);
            
        }
    }

    getNotes();

    function selectNote(id){
        var note;
        for (let i = 0; i < users.length; i++) {
            if(username == users[i].username)
                {
                    for (let j = 0; j < users[i].notes.length; j++) {
                        if(id == j)
                            note = users[i].notes[j];
                    } 
                }
        }    

        document.querySelector("#noteContent").textContent = note.noteContent;
        document.querySelector("#noteTitle").value = note.noteTitle;
    }

    const foundUserCombobox = document.querySelector("#foundUsers");
    for (let i = 0; i < users.length; i++)
        addNewUser(users[i]);

    function addNewUser(user){
        const u = document.createElement("option");
        u.value = user.username;
        u.text = u.value;
        foundUserCombobox.appendChild(u);
    }

    function searchUser(){
        const usernameSearchField = document.querySelector("#usernameSearchField").value;
        if(usernameSearchField.length < 3)
            alert("Please enter at least 3 characters!");

        for (let i = foundUserCombobox.children.length - 1; i >= 1; i--)
            foundUserCombobox.removeChild(foundUserCombobox.children[i]);

        for (let i = 0; i < users.length; i++) {
            const u = users[i];
            if(u.username.includes(usernameSearchField, 0)){
                addNewUser(u);
            }
        }
    }
    document.querySelector("#searchUserButton").addEventListener("click", searchUser);

    function createText(){
        const noteTitle = document.querySelector("#noteTitle").value;
        if(noteTitle.length == 0)
            alert("You have to enter a name!");

    }
    //document.querySelector("#addUser").addEventListener("click", addUser);
    //document.querySelector("#removeUser").addEventListener("click", removeUser);