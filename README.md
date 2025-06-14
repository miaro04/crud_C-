# 🧩 Gestion des pièces - Windows Forms CRUD (C# + SQLite)

Ce projet est une petite application de bureau (Windows Forms) en C# qui permet de **gérer une liste de pièces** à l'aide d'une base de données SQLite locale.

---

## 📌 Fonctionnalités

- 🔍 Lister toutes les pièces
- ➕ Ajouter une nouvelle pièce
- 📝 Modifier une pièce sélectionnée
- ❌ Supprimer une pièce
- 🗃️ Base de données locale SQLite auto-générée

---

## 📋 Structure de la table `pieces`

| Champ         | Type      | Description                     |
|---------------|-----------|----------------------------------|
| id            | INTEGER   | Clé primaire auto-incrémentée    |
| nom           | TEXT      | Nom de la pièce                  |
| reference     | TEXT      | Référence unique de la pièce     |
| prix          | REAL      | Prix de la pièce                 |
| disponibilite | BOOLEAN   | Disponible ou non (true/false)   |

---

## 🛠️ Technologies

- C# (POO)
- WinForms (.NET 6+)
- SQLite
- System.Data.SQLite (NuGet)

---

## 🧪 Lancer l'application

1. **Cloner ou télécharger** le projet.
2. Ouvrir la solution `.sln` dans Visual Studio.
3. Restaurer les packages NuGet :
   - `System.Data.SQLite.Core` si non présent.
4. Compiler et exécuter (`Ctrl + F5`).
5. Utiliser l'interface pour gérer les pièces.

⚠️ La base `pieces.db` est générée automatiquement dans :
bin\Debug\net6.0-windows\

