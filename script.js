"use strict";

var username;
const users = [
  {
    username: "eyup",
    password: "1111",
    mail: "eyuphankaygusuz@gmail.com",
    notes: [
      {
        id: 0,
        noteCreator: "eyup",
        noteTitle: "Toplantı Sonuçları - Not Alma Sitesi Geliştirme Toplantısı",
        noteContent: `Tarih: 8 Haziran 2024
Saat: 14:00 - 15:30

Katılımcılar:

Ahmet Yılmaz (Proje Yöneticisi)
Eyüphan Kaygusuz (Yazılım Geliştirici)
Mehmet Kaya (UI/UX Tasarımcısı)
Ayşe Özkan (Ürün Yöneticisi)
Fatma Aksoy (Müşteri Temsilcisi)
Gündem:

Proje Durumu
Kullanıcı Geri Bildirimleri
Yeni Özellikler
Takvim ve Yol Haritası
1. Proje Durumu

Çoğu hedefe ulaşıldı. (Ahmet Yılmaz)
Veri senkronizasyonu ve offline erişimde ilerleme sağlandı. (Eyüphan Kaygusuz)
UI güncellemeleri yapıldı. (Mehmet Kaya)
2. Kullanıcı Geri Bildirimleri

Kullanıcılar hızdan memnun, ek özellikler istiyor: senkronizasyon, etiketleme, filtreleme. (Fatma Aksoy)
3. Yeni Özellikler

Etiket ekleme, gelişmiş arama, daha iyi senkronizasyon, yardım merkezi. (Ayşe Özkan)
Teknik detaylar ve zorluklar. (Eyüphan Kaygusuz)
4. Takvim ve Yol Haritası

Haziran: etiketleme, arama
Temmuz: senkronizasyon
Ağustos: yardım merkezi
Haftalık kontrol toplantıları
Sonuç ve Eylem Adımları:

Geri bildirim analizi, yeni özelliklerin geliştirilmesi, haftalık toplantılar.
Bir sonraki toplantı: 22 Haziran 2024, 14:00

Hazırlayan:
Eyüphan Kaygusuz`,
        addedUsers: ["omer"],
      },
      {
        id: 1,
        noteCreator: "omer",
        noteTitle: "Ortak Noktalar",
        noteContent:
          "Lorem ipsum dolor sit amet consectetur adipisicing elit. Itaque, amet odio iste error delectus aspernatur ut omnis at molestias, fugit quis. Laudantium qui aut fuga!",
        addedUsers: ["eyup"],
      },
    ],
  },
  {
    username: "baran",
    password: "2222",
    mail: "baran@gmail.com",
    notes: [],
  },
  {
    username: "omer",
    password: "3333",
    mail: "omeraydin@gmail.com",
    notes: [
      {
        id: 0,
        noteCreator: "eyup",
        noteTitle: "Toplantı Sonuçları - Not Alma Sitesi Geliştirme Toplantısı",
        noteContent: `Tarih: 8 Haziran 2024
Saat: 14:00 - 15:30

Katılımcılar:

Ahmet Yılmaz (Proje Yöneticisi)
Eyüphan Kaygusuz (Yazılım Geliştirici)
Mehmet Kaya (UI/UX Tasarımcısı)
Ayşe Özkan (Ürün Yöneticisi)
Fatma Aksoy (Müşteri Temsilcisi)
Gündem:

Proje Durumu
Kullanıcı Geri Bildirimleri
Yeni Özellikler
Takvim ve Yol Haritası
1. Proje Durumu

Çoğu hedefe ulaşıldı. (Ahmet Yılmaz)
Veri senkronizasyonu ve offline erişimde ilerleme sağlandı. (Eyüphan Kaygusuz)
UI güncellemeleri yapıldı. (Mehmet Kaya)
2. Kullanıcı Geri Bildirimleri

Kullanıcılar hızdan memnun, ek özellikler istiyor: senkronizasyon, etiketleme, filtreleme. (Fatma Aksoy)
3. Yeni Özellikler

Etiket ekleme, gelişmiş arama, daha iyi senkronizasyon, yardım merkezi. (Ayşe Özkan)
Teknik detaylar ve zorluklar. (Eyüphan Kaygusuz)
4. Takvim ve Yol Haritası

Haziran: etiketleme, arama
Temmuz: senkronizasyon
Ağustos: yardım merkezi
Haftalık kontrol toplantıları
Sonuç ve Eylem Adımları:

Geri bildirim analizi, yeni özelliklerin geliştirilmesi, haftalık toplantılar.
Bir sonraki toplantı: 22 Haziran 2024, 14:00

Hazırlayan:
Eyüphan Kaygusuz`,
        addedUsers: ["omer"],
      },
      {
        id: 1,
        noteCreator: "omer",
        noteTitle: "Ortak Noktalar",
        noteContent:
          "Lorem ipsum dolor sit amet consectetur adipisicing elit. Itaque, amet odio iste error delectus aspernatur ut omnis at molestias, fugit quis. Laudantium qui aut fuga!",
        addedUsers: ["eyup"],
      },
    ],
  },
];

var noteIndexCounter = 2;

const regUsernameInput = document.querySelector("#registerUsername");
const regPassword1 = document.querySelector("#registerPassword");
const regPassword2 = document.querySelector("#registerPassword2");
const regMail1 = document.querySelector("#registerMail");
const regMail2 = document.querySelector("#registerMail2");

const usernameInput = document.querySelector("#usernameField");
const passwordInput = document.querySelector("#passwordField");
const createAccountLink = document.querySelector("#createAccount");

const regInputs = [
  regUsernameInput,
  regPassword1,
  regPassword2,
  regMail1,
  regMail2,
];

for (let i = 0; i < regInputs.length; i++) {
  const element = regInputs[i];
  element.addEventListener("input", () => onTypeInput(element));
  element.addEventListener("focusout", () => onFocusOutField(element));
}

createAccountLink.addEventListener("click", () => {
  createAccountLink.classList.add("hidden");
  document.querySelector(".showroom").classList.add("hidden");
  document.querySelector(".register").classList.remove("hidden");
})

function register() {

  for (const element of regInputs) {
    if (isInputEmpty(element)) {
      return;
    }
  }
  
  if(users.filter((u) => u.username == regUsernameInput.value).length > 0) {
   alert("This username is already in use!");
    return;
  }
  if (regPassword1.value !== regPassword2.value) {
    alert("Passwords do not match!");
    return;
  }
  if (regMail1.value !== regMail2.value) {
    alert("Emails do not match!"); 
    return;
  }
  if (!validateEmail(regMail1.value)) {
    alert("E-mail is not valid!");
    return;
  }
  const newUser = {
    username: regUsernameInput.value,
    password: regPassword1.value,
    mail: regMail1.value,
    notes: [],
  };
  users.push(newUser);
  usernameInput.value = regUsernameInput.value;
  passwordInput.value = regPassword1.value;

  for (const element of regInputs)
    element.value = "";

  tryLogin();
}

document.querySelector("#signupButton").addEventListener("click",register);

function validateEmail(email) {
  return String(email)
    .toLowerCase()
    .match(
      /^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|.(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/
    );
}

function tryLogin() {
  if (isInputEmpty(usernameInput) || isInputEmpty(passwordInput)) return;

  var userFound = false;
  for (let i = 0; i < users.length; i++) {
    const user = users[i];

    if (
      user.username === usernameInput.value &&
      user.password == passwordInput.value
    ) {
      document.querySelector(".header").children[1].classList.add("hidden");
      document.querySelector(".showroom").classList.add("hidden");
      document.querySelector(".register").classList.add("hidden");
      document.querySelector(".header").children[2].classList.remove("hidden");
      document.querySelector(".mainContent").classList.remove("hidden");
      document.querySelector(".welcome").textContent =
        "Welcome, " + usernameInput.value + "!";
      userFound = true;
      username = usernameInput.value;

      getNotes();
      return;
    }
  }
  if (!userFound) alert("Wrong credentials!");
}
document.querySelector("#loginButton").addEventListener("click", tryLogin);

function isInputEmpty(input) {
  input.style.outline = "";
  if (input.value.length == 0) {
    input.style.outline = "2px solid red";
    return true;
  }
  return false;
}

function onFocusOutField(element) {
  if (element.value.length == 0) element.style.outline = "2px solid red";
  else element.style.outline = "";
}
usernameInput.addEventListener("focusout", () =>
  onFocusOutField(usernameInput)
);
passwordInput.addEventListener("focusout", () =>
  onFocusOutField(passwordInput)
);

function onTypeInput(element) {
  if (element.value.length != 0) element.style.outline = "2px solid green";
}
usernameInput.addEventListener("input", () => onTypeInput(usernameInput));
passwordInput.addEventListener("input", () => onTypeInput(passwordInput));

//-----------------------

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
  const noteChildCount = noteHolder.children.length;
  for (let i = 0; i < noteChildCount; i++) {
    noteHolder.removeChild(noteHolder.children[0]);
  }
  for (let i = 0; i < notes.length; i++) {
    const noteInformation = notes[i];
    const newNote = document.createElement("button");
    newNote.classList.add("note");

    var title = noteInformation.noteTitle;
    if (title.length > 22) title = title.substring(0, 30).concat("...");
    newNote.innerHTML = `
            <div class="noteInfo">
                <p class="noteID">${noteInformation.id}</p>
                <p class="noteTitle"><b>${title}</b></p>
                <p class="noteCreator">Creator: ${noteInformation.noteCreator}</p>
            </div>`;
    newNote.addEventListener("click", () => selectNote(noteInformation.id));
    noteHolder.appendChild(newNote);
  }
}

function selectNote(id) {
  for (let i = 0; i < users.length; i++)
    if (username == users[i].username) {
      const u = users[i];
      for (let j = 0; j < u.notes.length; j++) {
        if (id == u.notes[j].id) selectedNote = u.notes[j];
      }
      break;
    }
  document.querySelector("#noteContent").value = selectedNote.noteContent;
  document.querySelector("#noteTitle").value = selectedNote.noteTitle;
}

function searchUser() {
  const usernameSearchField = document.querySelector(
    "#usernameSearchField"
  );
  if (usernameSearchField.value.length < 3)
    alert("Please enter at least 3 characters!");
  
  for (let i = foundUserCombobox.children.length - 1; i >= 1; i--)
    foundUserCombobox.removeChild(foundUserCombobox.children[i]);
  
  for (let i = 0; i < users.length; i++) {
    const u = users[i];
    if (u.username.includes(usernameSearchField.value, 0)) {
      addUserToComboBox(u);
    }
  }
    usernameSearchField.value = "";
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

  for (let i = 0; i < users.length; i++) {
    if (users[i].username == username) {
      const notePush = {
        id: newID,
        noteCreator: username,
        noteTitle: "Untitled",
        noteContent: "",
        addedUsers: [],
      };
      users[i].notes.push(notePush);
    }
  }
  selectNote(newID);
}
document.querySelector("#createText").addEventListener("click", createText);

function deleteText() {
  if (!selectedNote) {
    alert("You have to choose a note!");
    return;
  }else if (selectedNote.noteCreator != username) {
    alert("You can't delete a note if you are not the creator!");
    return;
  }

  document.querySelector("#noteTitle").value = "";
  document.querySelector("#noteContent").value = "";

  const noteHolder = document.querySelector("#mainNotes");
  //Other users
  for (let i = 0; i < users.length; i++) {
    if (selectedNote.addedUsers.includes(users[i].username)) {
      for (let j = 0; j < users[i].notes.length; j++) {
        const note = users[i].notes[j];
        if (note.id == selectedNote.id)
           users[i].notes.splice(j, 1);
      }
    }
  }
  //Us
  for (let i = 0; i < users.length; i++) {
    if (users[i].username == username) {
      for (let j = 0; j < users[i].notes.length; j++) {
        const note = users[i].notes[j];
        if (note.id == selectedNote.id) users[i].notes.splice(j, 1);
      }
    }
  }
  selectedNote = false;
  getNotes();
}
document.querySelector("#deleteText").addEventListener("click", deleteText);

function saveText() {
  if (!selectedNote) {
    alert("You have to select a note!");
    return;
  }
  const title = document.querySelector("#noteTitle").value;
  const content = document.querySelector("#noteContent").value;
  const id = selectedNote.id;
  for (let i = 0; i < users.length; i++) {
    const u = users[i];
    for (let j = 0; j < u.notes.length; j++) {
      if (u.notes[j].id == id) {
        const note = u.notes[j];
        note.noteContent = content;
        note.noteTitle = title;
      }
    }
  }
}
document.querySelector("#saveText").addEventListener("click", saveText);

const foundUserCombobox = document.querySelector("#foundUsers");

function addUserToComboBox(user) {
  const u = document.createElement("option");
  u.value = user.username;
  u.text = u.value;
  foundUserCombobox.appendChild(u);
}

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
  } else if (selectedNote.noteCreator != username) {
    alert("You can't add or remove user if you are not the creator!");
    return;
  }

  users.forEach((u) => {

    u.notes.forEach((n) => {
      if (n.id == selectedNote.id) {
        n.addedUsers = selectedNote.addedUsers;
      }
    });

    if (u.username != uName) return;
    selectedNote.addedUsers.push(u.username);
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

  var noteFound = false;
  users.forEach((u) => {
    
    //For the other users who has the note
      u.notes.forEach(note => {
        note.addedUsers = note.addedUsers.filter(user => user !== uName);
      });
    
    //For the removed person
    if (u.username !== uName) return;

    const noteIndex = u.notes.findIndex(n => n.id === selectedNote.id);
    if (noteIndex !== -1) {
      u.notes.splice(noteIndex, 1);
      alert("Note removed from the user!");
    }

  });

  if (!noteFound) alert("This user does not have this note!");
}
document.querySelector("#removeUser").addEventListener("click", removeUser);

function logout() {
  usernameInput.value = "";
  passwordInput.value = "";
  document.querySelector("#usernameSearchField").value = "";
  foundUserCombobox.options.length = 1;
  selectedNote = false;
  document.querySelector("#noteTitle").value = "";
  document.querySelector("#noteContent").value = "";
  document.querySelector(".header").children[1].classList.remove("hidden");
  document.querySelector(".showroom").classList.remove("hidden");
  document.querySelector(".register").classList.add("hidden");
  document.querySelector(".header").children[2].classList.add("hidden");
  document.querySelector(".mainContent").classList.add("hidden");
  createAccountLink.classList.remove("hidden");
  document.querySelector(".welcome").textContent = "";
  username = "";
  alert("Logged Out!");
}
document.querySelector("#logout").addEventListener("click", logout);
