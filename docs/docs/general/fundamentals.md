@todo: add links to pages, items, etc
@todo: vid for this page

## Creating a New Mesh

Like most 3D modeling tools, ProBuilder includes a library of shapes (cube, cylinder, torus, etc), to begin modeling with. Which each of these shapes, you can customize both starting dimensions and unique parameters.

You can also start with an imported mesh by "ProBuilderizing" it.

## Editing Meshes

### Object vs Element

ProBuilder is always in one of 2 major modes: **Object** or **Element**.

* **Object Mode** is standard Unity mode, no surprises.
* **Element Mode** activates ProBuilder's geometry editing features for **Vertex**, **Edge**, and **Face** elements. 

### Element Editing: Vertex, Edge, Face

**Elements** are the individual parts that make up a mesh: Vertices, Edges, and Faces. If it helps, you can think of these like levels of detail on a map- for example, "city, state, country".

* **Vertex Editing**: Select and edit Vertices for detailed editing and functions like vertex splitting and connecting.
* **Edge Editing**: Select and edit Edges for semi-complex geometry editing, and Edge Loop Modeling techniques.
* **Face Editing**: Select and edit Faces on an object, performing basic tasks like deleting faces and extruding.

### Element Selection and Manipulation

Good news- if you know how to select and move, rotate, or scale objects in Unity, you already know this part!

The only extra step is to choose which Element type you'd like to edit, by clicking it's button in the "Edit Mode Toolbar".

Then, use any of the standard Unity selection methods (click, drag, etc) and manipulation controls (move, rotate, scale), just as you would on any other object(s).

### Extrude Faces, Collapse Vertices, Connect Edges, Etc

All of ProBuilder's element-editing functions are available via the ProBuilder Toolbar, which dynamically adapts to your Edit Mode and selection.

There are also custom, detailed tooltips tooltips for each button, a great way to start learning ProBuilder's deeper functionality.

## Materials and Texturing / UV Editing

### Applying Materials

You can apply any material (including Substance, etc) to ProBuilder meshes, using standard "drag-n-drop" method or ProBuilder's Material Palette.

Materials can also be applied to individual faces of a ProBuilder mesh, while in Element Mode.

### Texturing and UV Editing

ProBuilder includes both a simple, automatic texturing system, and a full UV Editing and Unwrapping system.

**You may use whichever you prefer, or a mix of both, even on the same mesh.**

* **Auto UVs** lets you to easily tweak basics like Offset, Tiling, and Rotation, while ProBuilder handles the complex UV work automoatically
* **Manual UVs** gives you complete control of the UVs, including Projection Mapping, UV Stitching, and more, similar to UV editors in major tools like 3DS Max, Blender, etc.   


