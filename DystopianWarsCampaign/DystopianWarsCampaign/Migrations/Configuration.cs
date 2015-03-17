namespace DystopianWarsCampaign.Migrations
{
    using DystopianWarsCampaign.Models;
    using DystopianWarsCampaign.Models.CampaignModels;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DystopianWarsCampaign.Models.DystopianCampaignContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DystopianWarsCampaign.Models.DystopianCampaignContext context)
        {
            var territoryBonuses = new TerritoryBonus[]
            {
                new TerritoryBonus{Name="Town", Description="+10 additional requisition per turn."},
                new TerritoryBonus{Name="Town", Description="+10 additional requisition per turn."},
                new TerritoryBonus{Name="Oil Rigs", Description="+10 additional requisition per turn."},
                new TerritoryBonus{Name="Oil Rigs", Description="+10 additional requisition per turn."},
                new TerritoryBonus{Name="Industrial Complex", Description="+10 additional requisition per turn."},
                new TerritoryBonus{Name="Inhospitable", Description="Upgrades on this territory cost an additional 50%."},
                new TerritoryBonus{Name="Inhospitable", Description="Upgrades on this territory cost an additional 50%."},
                new TerritoryBonus{Name="Monument", Description="Uses standard tower stats without weapons. Provides Die Hard Attitude (Owner's Faction, 16'')."},
                new TerritoryBonus{Name="Lighthouse", Description="Uses standard tower stats without weapons. May function as an Expert Spotter."}
            };
            context.TerritoryBonuses.AddOrUpdate(tb => tb.Name, territoryBonuses);
            context.SaveChanges();

            var territoryUpgrades = new TerritoryUpgrade[]
            {
                new TerritoryUpgrade{Name="Upgrade 1", Description="Upgrade description goes here."},
                new TerritoryUpgrade{Name="Upgrade 2", Description="Upgrade description goes here."},
                new TerritoryUpgrade{Name="Upgrade 3", Description="Upgrade description goes here."},
                new TerritoryUpgrade{Name="Upgrade 4", Description="Upgrade description goes here."},
                new TerritoryUpgrade{Name="Upgrade 5", Description="Upgrade description goes here."},
                new TerritoryUpgrade{Name="Upgrade 6", Description="Upgrade description goes here."}
            };
            context.TerritoryUpgrades.AddOrUpdate(tu => tu.Name, territoryUpgrades);
            context.SaveChanges();

            
            var factions = new Faction[]
            {
                new Faction{
                    Name="Federated States of America", 
                    Acronym="FSA", 
                    FlagURL="~/Content/Images/FSA.jpg", 
                    AwayFleet=@"<table>
                        <thead><tr><th>Name</th><th>Type</th><th>Points</th></tr></thead>
                        <tbody>
                        <tr><td>1x Savannah (Sky Fortress) </td><td> Aer. Massive </td><td> 165    </td></tr>
                        <tr><td>1x Valley (Airship) </td><td> Aer. Large </td><td> 150           </td></tr>
                        <tr><td>1x Boston (Attack Submarine) </td><td> Nav. Large </td><td> 145    </td></tr>
                        <tr><td>1x Liberty (Heavy Battleship) </td><td> Nav. Large </td><td> 215 </td></tr>
                        <tr><td>1x Annapolis (Battle Cruiser) </td><td> Nav. Medium </td><td> 115  </td></tr>                        
                        <tr><td>1x Annapolis (Battle Cruiser) </td><td> Nav. Medium </td><td> 115  </td></tr>
                        <tr><td>3x Georgetown MkII (Cruiser) </td><td> Nav. Medium </td><td> 210   </td></tr>
                        <tr><td>3x Lee (Scoutship) </td><td> Aer. Medium </td><td> 240            </td></tr>
                        <tr><td>3x Princeton (Gunship) </td><td> Nav. Medium </td><td> 270      </td></tr>
                        <tr><td>4x Augusta (Frigate) </td><td> Nav. Small </td><td> 120        </td></tr>
                        <tr><td>5x Avion (Strike Bomber) </td><td> Aer. Small </td><td> 150       </td></tr>
                        <tr><td>4x Guilford (Destroyer) </td><td> Nav. Small </td><td> 160       </td></tr>
                        <tr><td>5x Revere (Corvette) </td><td> Nav. Small </td><td> 100          </td></tr>
                        <tr><td><b>TOTAL</b> </td><td> </td><td>  <b>  2155       </b></td></tr>
                        </tbody>
                    </table>",
                    HomeFleet=@"<table>
                        <thead><tr><th>Name</th><th>Type</th><th>Points</th></tr></thead>
                        <tbody>
                        <tr><td>1x Enterprise (Dreadnought) </td><td> Nav. Massive </td><td> 280 </td></tr>
                        <tr><td>1x Savannah (Sky Fortress) </td><td> Aer. Massive </td><td> 165         </td></tr>
                        <tr><td>1x Valley (Airship) </td><td> Aer. Large </td><td> 150                  </td></tr>
                        <tr><td>1x Liberty (Heavy Battleship) </td><td> Nav. Large </td><td> 215 </td></tr>
                        <tr><td>1x Boston (Attack Submarine) </td><td> Nav. Large </td><td> 145         </td></tr>
                        <tr><td>1x Independence (Battleship) </td><td> Nav. Large </td><td> 180         </td></tr>
                        <tr><td>3x A17 (Bomber) </td><td> Aer. Medium </td><td> 180                     </td></tr>
                        <tr><td>1x Annapolis (Battle Cruiser) </td><td> Nav. Medium </td><td> 115       </td></tr>
                        <tr><td>1x Annapolis (Battle Cruiser) </td><td> Nav. Medium </td><td> 115       </td></tr>
                        <tr><td>3x Georgetown MkII (Cruiser) </td><td> Nav. Medium </td><td> 210        </td></tr>
                        <tr><td>3x Lexington MkII (Light Cruiser) </td><td> Nav. Medium </td><td> 165   </td></tr>
                        <tr><td>4x Augusta (Frigate) </td><td> Nav. Small </td><td> 120                 </td></tr>
                        <tr><td>4x Augusta (Frigate) </td><td> Nav. Small </td><td> 120                 </td></tr>
                        <tr><td>5x Avion (Strike Bomber) </td><td> Aer. Small </td><td> 150             </td></tr>
                        <tr><td>3x Guilford (Destroyer) </td><td> Nav. Small </td><td> 120              </td></tr>
                        <tr><td>3x Springfield (Escort) </td><td> Nav. Small </td><td> 60               </td></tr>
                        <tr><td><b>TOTAL</b> </td><td> </td><td>  <b>  2490       </b></td></tr>
                        </tbody>
                    </table>"
                },
                new Faction{
                    Name="Prussian Empire",
                    Acronym="PE",
                    FlagURL="~/Content/Images/PE.jpg",
                    AwayFleet=@"<table>
                        <thead><tr><th>Name</th><th>Type</th><th>Points</th></tr></thead>
                        <tbody>
                        <tr><td>1x Elbe (Fleet Carrier) </td><td> Nav. Massive </td><td> 210        </td></tr>    
                        <tr><td>1x Imperium (Sky Fortress) </td><td> Aer. Massive </td><td> 145     </td></tr>
                        <tr><td>1x Kaiser Karl (Heavy Battleship) </td><td> Nav. Large </td><td> 220</td></tr>
                        <tr><td>1x Sturmbringer (Submarine) </td><td> Nav. Large </td><td> 155      </td></tr>
                        <tr><td>3x Donnerfaust (Support Cruiser) </td><td> Nav. Medium </td><td> 255</td></tr>
                        <tr><td>1x Königsberg (Battle Cruiser) </td><td> Nav. Medium </td><td> 110  </td></tr>
                        <tr><td>3x Pflicht (Scoutship) </td><td> Aer. Medium </td><td> 240          </td></tr>
                        <tr><td>3x Riever (Light Cruiser) </td><td> Nav. Medium </td><td> 150       </td></tr>
                        <tr><td>3x Uhlan (Cruiser) </td><td> Nav. Medium </td><td> 195              </td></tr>
                        <tr><td>4x Arminius (Frigate) </td><td> Nav. Small </td><td> 120            </td></tr>
                        <tr><td>5x Saxony (Corvette) </td><td> Nav. Small </td><td> 100             </td></tr>
                        <tr><td>5x Saxony (Corvette) </td><td> Nav. Small </td><td> 100             </td></tr>
                        <tr><td><b>TOTAL</b> </td><td> </td><td>  <b>  2000       </b></td></tr>
                        </tbody>
                    </table>",
                    HomeFleet=@"<table>
                        <thead><tr><th>Name</th><th>Type</th><th>Points</th></tr></thead>
                        <tbody>
                        <tr><td>1x Blücher (Dreadnought) </td><td> Nav. Massive </td><td> 290                           </td></tr>
                        <tr><td>1x Imperium (Sky Fortress) </td><td> Aer. Massive </td><td> 145                         </td></tr>
                        <tr><td>1x Kaiser Karl (Heavy Battleship) </td><td> Nav. Large </td><td> 235                    </td></tr>
                        <tr><td>1x Sturmbringer (Submarine) </td><td> Nav. Large </td><td> 155                          </td></tr>
                        <tr><td>3x Hussar (Gunship) </td><td> Nav. Medium </td><td> 255                                 </td></tr>
                        <tr><td>3x Donnerfaust (Support Cruiser) </td><td> Nav. Medium </td><td> 255                    </td></tr>
                        <tr><td>3x Geier (Bomber) </td><td> Aer. Medium </td><td> 180                                   </td></tr>
                        <tr><td>1x Königsberg (Battle Cruiser) </td><td> Nav. Medium </td><td> 110                      </td></tr>
                        <tr><td>3x Uhlan (Cruiser) </td><td> Nav. Medium </td><td> 195                                  </td></tr>
                        <tr><td>3x Wächter (Escort) </td><td> Nav. Small </td><td> 75                                   </td></tr>
                        <tr><td>5x Saxony (Corvette) </td><td> Nav. Small </td><td> 100                                 </td></tr>
                        <tr><td>5x Saxony (Corvette) </td><td> Nav. Small </td><td> 100                                 </td></tr>
                        <tr><td>4x Speerwurf (Strike Airship) </td><td> Aer. Small </td><td> 100                        </td></tr>
                        <tr><td>2x Arminius (Frigate) </td><td> Nav. Small </td><td> 60                                 </td></tr>
                        <tr><td><b>TOTAL</b> </td><td> </td><td>  <b>  2255       </b></td></tr>
                        </tbody>
                    </table>"
                },
                new Faction{
                    Name="Covenant of Sidrial", 
                    Acronym="SID", 
                    FlagURL="~/Content/Images/SID.jpg",
                    AwayFleet=@"<table>
                        <thead><tr><th>Name</th><th>Type</th><th>Points</th></tr></thead>
                        <tbody>
                        <tr><td>1x Euclid (Sky Dreadnought) </td><td> Aer. Massive </td><td> 275 </td></tr>
                        <tr><td>1x Diophantus (Assault Carrier) </td><td> Nav. Massive </td><td> 200</td></tr>
                        <tr><td>1x Callimachus-Alpha (Time Orb) </td><td> Arm. Large </td><td> 90   </td></tr>
                        <tr><td>1x Callimachus-Beta (Battle Orb) </td><td> Arm. Large </td><td> 85 </td></tr>
                        <tr><td>1x Aristotle (Battleship) </td><td> Nav. Large </td><td> 200      </td></tr>
                        <tr><td>1x Hippasus (Battle Cruiser) </td><td> Nav. Medium </td><td> 130   </td></tr>
                        <tr><td>2x Fresnel (Gunship) </td><td> Nav. Medium </td><td> 180             </td></tr>
                        <tr><td>2x Fresnel (Gunship) </td><td> Nav. Medium </td><td> 180            </td></tr>
                        <tr><td>3x Zeno (Armoured Cruiser) </td><td> Nav. Medium </td><td> 270      </td></tr>
                        <tr><td>3x Cleomedes (Cruiser) </td><td> Nav. Medium </td><td> 240 </td></tr>
                        <tr><td>3x Plutarch (Heavy Destroyer) </td><td> Nav. Small </td><td> 135    </td></tr>
                        <tr><td>2x Plutarch (Heavy Destroyer) </td><td> Nav. Small </td><td> 90     </td></tr>
                        <tr><td>4x Diogenes (Frigate) </td><td> Nav. Small </td><td> 100           </td></tr>
                        <tr><td>4x Diogenes (Frigate) </td><td> Nav. Small </td><td> 100           </td></tr>
                        <tr><td>5x Thales (Corvette) </td><td> Nav. Small </td><td> 100            </td></tr>
                        <tr><td>5x Thales (Corvette) </td><td> Nav. Small </td><td> 100             </td></tr>
                        <tr><td>1x Galen (Escort) </td><td> Nav. Small </td><td> 25                   </td></tr>
                        <tr><td><b>TOTAL</b> </td><td> </td><td>  <b>  2500       </b></td></tr>
                        </tbody>
                    </table>",
                    HomeFleet=@"<table>
                        <thead><tr><th>Name</th><th>Type</th><th>Points</th></tr></thead>
                        <tbody>
                         <tr><td>1x Prometheus (Dreadnought) </td><td> Nav. Massive </td><td> 320      </td></tr>
                         <tr><td>1x Pericles (Fleet Carrier) </td><td> Nav. Massive </td><td> 165    </td></tr>    
                         <tr><td>1x Epicurus (Sky Fortress) </td><td> Aer. Massive </td><td> 180           </td></tr>
                         <tr><td>1x Aristotle (Battleship) </td><td> Nav. Large </td><td> 200     </td></tr>
                         <tr><td>1x Callimachus-Beta (Battle Orb) </td><td> Arm. Large </td><td> 85       </td></tr>
                         <tr><td>1x Callimachus-Alpha (Time Orb) </td><td> Arm. Large </td><td> 90         </td></tr>
                         <tr><td>1x Hippasus (Battle Cruiser) </td><td> Nav. Medium </td><td> 130   </td></tr>
                         <tr><td>2x Fresnel (Gunship) </td><td> Nav. Medium </td><td> 180             </td></tr>
                         <tr><td>1x Fresnel (Gunship) </td><td> Nav. Medium </td><td> 90                </td></tr>
                         <tr><td>3x Zeno (Armoured Cruiser) </td><td> Nav. Medium </td><td> 270         </td></tr>
                         <tr><td>4x Diogenes (Frigate) </td><td> Nav. Small </td><td> 100                </td></tr>
                         <tr><td>3x Plutarch (Heavy Destroyer) </td><td> Nav. Small </td><td> 135        </td></tr>
                         <tr><td>2x Galen (Escort) </td><td> Nav. Small </td><td> 50                   </td></tr>
                        <tr><td><b>TOTAL</b> </td><td> </td><td>  <b>  1995       </b></td></tr>
                        </tbody>
                    </table>"
                },
                new Faction{
                    Name="Covenant of Antarctica 11th War Fleet 'Novalis's Mercy'",
                    Acronym="COA", 
                    FlagURL="~/Content/Images/COA.jpg",
                    AwayFleet="",
                    HomeFleet=""
                },
                new Faction{
                    Name="Republique of France", 
                    Acronym="RoF", 
                    FlagURL="~/Content/Images/ROF.jpg",
                    AwayFleet=@"<table>
                        <thead><tr><th>Name</th><th>Type</th><th>Points</th><th>Upgrades</th></tr></thead>
                        <tbody>   
                        <tr><td> 1x Charlemagne (Dreadnought) </td><td> Nav. Massive </td><td> 330 </td><td> IG Cloud & IG Tesla      </td></tr>
                        <tr><td> 1x Couronne (Assault Carrier) </td><td> Nav. Massive </td><td> 175 </td><td> IG Cloud & Stoic Crew   </td></tr>
                        <tr><td> 1x Saint-Malo (Heavy Battleship) </td><td> Nav. Large </td><td> 235 </td><td> IG Null & Elite Crew   </td></tr>
                        <tr><td> 3x Écuyer (Support Cruiser) </td><td> Nav. Medium </td><td> 210                                      </td></tr>
                        <tr><td> 1x Cherbourg (Battle Cruiser) </td><td> Nav. Medium </td><td> 120 </td><td> Stoic Crew               </td></tr>
                        <tr><td> 1x Cherbourg (Battle Cruiser) </td><td> Nav. Medium </td><td> 120 </td><td> Stoic Crew               </td></tr>
                        <tr><td> 1x Cherbourg (Battle Cruiser) </td><td> Nav. Medium </td><td> 120 </td><td> Stoic Crew               </td></tr>
                        <tr><td> 3x Dieppe (Cruiser) </td><td> Nav. Medium </td><td> 240 </td><td> Aggresive Crew                     </td></tr>
                        <tr><td> 2x Toulon (Armoured Cruiser) </td><td> Nav. Medium </td><td> 180 </td><td> Stoic Crew                </td></tr>
                        <tr><td> 4x Chevalier (Heavy Destroyer) </td><td> Nav. Small </td><td> 160                                    </td></tr>
                        <tr><td> 4x Lyon (Frigate) </td><td> Nav. Small </td><td> 100                                                 </td></tr>
                        <tr><td><b>TOTAL</b> </td><td> </td><td>  <b>  1990       </b></td></tr>
                        </tbody>
                    </table>",
                    HomeFleet=@"<table>
                        <thead><tr><th>Name</th><th>Type</th><th>Points</th><th>Upgrades</th></tr></thead>
                        <tbody>                    
                        <tr><td> 1x Charlemagne (Dreadnought) </td><td> Nav. Massive </td><td> 330 </td><td> IG Cloud & IG Tesla                            </td></tr>
                        <tr><td> 1x Vauban (Surface Skimming Dreadnought) </td><td> Nav. Massive </td><td> 320 </td><td> IG Cloud                           </td></tr>
                        <tr><td> 1x Couronne (Assault Carrier) </td><td> Nav. Massive </td><td> 175 </td><td> IG Cloud & Stoic Crew                         </td></tr>
                        <tr><td> 1x La Rochelle (Heavy Skimming Battleship) </td><td> Nav. Large </td><td> 245 </td><td> IG Cloud & IG Null & Stoic Crew    </td></tr>
                        <tr><td> 3x Écuyer (Support Cruiser) </td><td> Nav. Medium </td><td> 210                                                            </td></tr>
                        <tr><td> 1x Cherbourg (Battle Cruiser) </td><td> Nav. Medium </td><td> 120 </td><td> Stoic Crew                                     </td></tr>
                        <tr><td> 3x Marseille (Light Cruiser) </td><td> Nav. Medium </td><td> 180                                                           </td></tr>
                        <tr><td> 4x Alma (Reconnaissance Frigate) </td><td> Nav. Small </td><td> 120                                                        </td></tr>
                        <tr><td> 4x Chevalier (Heavy Destroyer) </td><td> Nav. Small </td><td> 160                                                          </td></tr>
                        <tr><td> 5x Requin (Corvette) </td><td> Nav. Small </td><td> 100                                                                    </td></tr>
                        <tr><td><b>TOTAL</b> </td><td> </td><td>  <b>  1960       </b></td></tr>
                          </tbody>
                    </table>"
                },
                new Faction{Name="Neutral", Acronym="-", FlagURL="", AwayFleet="", HomeFleet=""}
            };


            context.Factions.AddOrUpdate(fac => fac.Name, factions);
            context.SaveChanges();

            var territories = new Territory[]
            {
                new Territory{Name="Territory 01", Faction=factions[5], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 02", Faction=factions[0], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 03", Faction=factions[0], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 04", Faction=factions[5], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 05", Faction=factions[2], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 06", Faction=factions[2], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 07", Faction=factions[4], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 08", Faction=factions[0], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 09", Faction=factions[5], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 10", Faction=factions[5], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 11", Faction=factions[2], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 12", Faction=factions[5], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 13", Faction=factions[4], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 14", Faction=factions[5], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 15", Faction=factions[5], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 16", Faction=factions[5], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 17", Faction=factions[5], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 18", Faction=factions[5], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 19", Faction=factions[4], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 20", Faction=factions[5], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 21", Faction=factions[3], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 22", Faction=factions[5], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 23", Faction=factions[1], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 24", Faction=factions[1], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 25", Faction=factions[5], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 26", Faction=factions[5], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 27", Faction=factions[3], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 28", Faction=factions[3], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 29", Faction=factions[5], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 30", Faction=factions[1], Description="Description goes here", FlagXCoord=0, FlagYCoord=0}
            };
            //Towns
            territories[14].Bonuses.Add(territoryBonuses[0]);
            territories[21].Bonuses.Add(territoryBonuses[1]);
            //Rigs
            territories[9].Bonuses.Add(territoryBonuses[2]);
            territories[15].Bonuses.Add(territoryBonuses[3]);
            //Industrial Complex
            territories[8].Bonuses.Add(territoryBonuses[4]);
            //Inhospitable
            territories[11].Bonuses.Add(territoryBonuses[5]);
            territories[24].Bonuses.Add(territoryBonuses[6]);
            //Monuments
            territories[28].Bonuses.Add(territoryBonuses[7]);

            context.Territories.AddOrUpdate(t => t.Name, territories);
            context.SaveChanges();
        }
    }
}
