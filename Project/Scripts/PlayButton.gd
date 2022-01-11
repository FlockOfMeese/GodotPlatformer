extends Button

func _ready():
	self.connect("pressed", self, "_changeScene")
	
func _changeScene():
	get_tree().change_scene("res://Scenes/Game.tscn")
