while true do
	Screen.refresh()
	Screen.clear(TOP_SCREEN)
	Screen.debugPrint(0, 0, "Hello World modified!", Color.new(255,255,255), TOP_SCREEN)
	Screen.flip()
	Screen.waitVblankStart()
	if Controls.check(Controls.read(), KEY_A) then
		dofile("/scripts/test.lua")
	end
end